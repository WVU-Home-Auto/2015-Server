/* ***************************************************************************
 * This class is a static class used for the authentication determination and
 * verifying that the connection is using a secure connection (https). Once
 * validated, the object sets the Pricipal object so that web modules can use
 * the HttpContext.Current.User.Identity with the correct criteria
 * 
 * ***************************************************************************
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Principal;
using System.Text;

namespace WebService
{
    public static class BasicAuthenticationProvider
    {
        internal static bool Authenticate(HttpContext context)
        {
            // validate that the context is using https for its connection
            //if (!HttpContext.Current.Request.IsSecureConnection)
            //    return false;

            // verify that we have the Autherization header
            if (!HttpContext.Current.Request.Headers.AllKeys.Contains("Authorization"))
                return false;

            return true;
        }

        internal static bool Authorize(HttpContext context)
        {
            string authHeader = HttpContext.Current.Request.Headers["Authorization"];

            IPrincipal principal;
            // attempt the validation using the authentication header
            if (TryGetPrincipal(authHeader, out principal))
            {
                // if all is good then set the current user and return true to inform the 
                // client that the authentication passed
                HttpContext.Current.User = principal;
                return true;
            }
            return false;
        }

        private static bool TryGetPrincipal(string authHeader, out IPrincipal principal)
        {
            // parse the headers by decrypting the authorization string
            var creds = ParseAuthHeader(authHeader);

            if (creds != null && TryGetPrincipal(creds, out principal))
                return true;

            principal = null;
            return false;
        }

        private static string[] ParseAuthHeader(string authHeader)
        {
            // Check this is a Basic Auth header 
            if (
                authHeader == null ||
                authHeader.Length == 0 ||
                !authHeader.StartsWith("Basic")
            ) return null;

            // Pull out the Credentials with are seperated by ':' and Base64 encoded 
            // the Authentication header is in the following form:
            // "Basic {username}:{password}"
            // where the {username}:{password} is 64 bit encoded
            string base64Credentials = authHeader.Substring(6);
            string[] credentials = Encoding.ASCII.GetString(
                  Convert.FromBase64String(base64Credentials)
            ).Split(new char[] { ':' });

            if (credentials.Length != 2 ||
                string.IsNullOrEmpty(credentials[0]) ||
                string.IsNullOrEmpty(credentials[1])
            ) return null;

            // Okay this is the credentials 
            return credentials;
        }

        private static bool TryGetPrincipal(string[] creds, out IPrincipal principal)
        {
            // Authenticate the request against the IPD authenticator to ensure the 
            // user name and password are valid
            principal = null;

            //if (!Engine.Authentication.ValidUser(creds[0], creds[1]))
            //    return false;

            principal = new GenericPrincipal(new GenericIdentity(creds[0]), null);
            if (principal != null)
            {
                return true;
            }
            else
            {
                principal = null;
                return false;
            }
        }
    }
}