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
        public static Conn db;
        public void connect()
        {
            db = Conn.GetInstance("TGGDB");
        }

        public BsonDocument CheckUser(string email, string password)
        {          
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                return default(BsonDocument);
            }
            else
            {
                return db.LoadRecordByEmail<BsonDocument>("Users", email);
            }
        }

        public BsonDocument CheckUserExists(string inputEmail)
        {
            var user = db.LoadRecordByEmail<BsonDocument>("Users", inputEmail);
            return user;
        }
 
        public void ConUpdatePassword(string email, string newPassword)
        {
            db.UpdatePassword<BsonDocument>("Users", email, newPassword);
        }
    }
}
