using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CINCOPA.Model;

namespace CINCOPA.Common
{
    public class Authentification
    {
        private static bool authentificated;
        private static USER currentUser;

        public static bool Authentificated()
        {
            return authentificated;
        }

        public static USER GetCurrentUser()
        {
            return currentUser;
        }

        public static bool AuthentificateUser(USER user)
        {
            var cu = DataManager.Instance.GetUser(user.NAME, user.PASSWORD);
            if (cu != null)
            {
                currentUser = cu;
                authentificated = true;
                return true;
            }
            else
            {
                currentUser = null;
                authentificated = false;
                return false;
            }
           
        }
    }
}
