using DatabaseWrapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Authentication
    {
        public static Boolean ValidUser(string username, string password)
        {
            User user = new User();
            return user.Authenticate(username, password);
        }
    }
}