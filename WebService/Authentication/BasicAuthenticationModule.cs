/* ***********************************************************************
 * This class is used to customize the Basic authentication option of IIS
 * This class should be registered as a Module in the Web.Server section
 * of the web.config so that IIS can consume it prior to the application 
 * start. The class adds an additional event handler to the Authentication
 * Request and returns a 401 Unauthorized is the authentication fails.
 * 
 * Nizar Diab (2/24/2012)
 *
 * ***********************************************************************
 */

using WebService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebService
{
    public class BasicAuthenticationModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.AuthenticateRequest
               += new EventHandler(context_AuthenticateRequest);
        }

        public void context_AuthenticateRequest(object sender, EventArgs e)
        {
            // We are forcing a Basic authentication scheme by adding the 
            // header to the response if the request did not include valid 
            // authentication. 
            // The browser (or client) will typically resend the request with
            // authentication included after recieving the first response
            // asking for authentication.
            HttpApplication application = (HttpApplication)sender;
            if (!BasicAuthenticationProvider.Authenticate(application.Context))
            {
                application.Context.Response.Status = "401 Unauthorized";
                application.Context.Response.StatusCode = 401;
                application.Context.Response.AddHeader("WWW-Authenticate", "Basic");
                application.CompleteRequest();
                return;
            }

            // if the client passed credentials, we need to authorize
            // the credentials and if not valid return a 403 Forbidden
            // status to the client
            if (!BasicAuthenticationProvider.Authorize(application.Context))
            {
                application.Context.Response.Status = "403 Forbidden";
                application.Context.Response.StatusCode = 403;
                application.CompleteRequest();
                return;
            }
        }

        public void Dispose() { }
    }
}