using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class ConSession
    {
        public void AddSession(string name, string email)
        {
            LoginInfo.UserName = name;
            LoginInfo.Email = email;
        }

        public string GetUsername()
        {
            return LoginInfo.UserName;
        }

        public string GetEmail()
        {
            return LoginInfo.Email;
        }
    }
}
