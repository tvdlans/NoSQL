using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Controller
{
    public class Login
    {
        public void connect()
        {
            Conn db = Conn.GetInstance("TGGDB");
        }

        public Boolean CheckUser(string email, string password)
        {
            Conn db = Conn.GetInstance("TGGDB");
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            else
            {
                var user = db.LoadRecordByEmail<BsonDocument>("Users", email);
                if (user == null)
                {
                    Console.WriteLine("huh");
                    return false;
                }
                else if (user.GetElement("Password").Value.ToString() == password)
                {
                    return true;
                }
                else return false;
            }
        }
    }
}
