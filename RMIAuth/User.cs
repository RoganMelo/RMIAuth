using System;
using System.Text.RegularExpressions;

namespace RMIAuthServer
{
    public class User : MarshalByRefObject, IUser
    {
        public bool IsValidUser(string name, string password)
        {
            return IsValidName(name) && IsValidPassword(password) ? true : false;
        }

        private bool IsValidName(string name)
        {
            return Regex.IsMatch(name, @"[A-Z][a-z]+");
        }

        private bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"[a-zA-Z]+[0-9]+|[0-9]+[a-zA-Z]+");
        }
    }
}
