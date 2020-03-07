using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace Controller
{
    public class Login
    {
        public Boolean CheckUser(string email, string password)
        {
            Conn db = Conn.GetInstance("TGGDB");
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                var user = db.LoadRecordByEmail<User>("Users", email);
                if (user.Password == password)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
