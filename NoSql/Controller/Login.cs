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
        // initializing the connection with the database
        public void connect()
        {
            db = Conn.GetInstance("TGGDB");
        }

        // checks if the user exists and if it exists return that user
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

        // checks if the user exists and if it exists return that user
        public BsonDocument CheckUserExists(string inputEmail)
        {
            var user = db.LoadRecordByEmail<BsonDocument>("Users", inputEmail);
            return user;
        }
        
        // updates the password of the user 
        public void ConUpdatePassword(string email, string newPassword)
        {
            db.UpdatePassword<BsonDocument>("Users", email, newPassword);
        }
    }
}
