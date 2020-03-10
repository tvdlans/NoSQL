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
    public class ConIncident
    {
        public List<string> getUsers()
        {
            Conn db = Conn.GetInstance("TGGDB");
            //get the users from the database
            var userList = db.LoadRecords<BsonDocument>("Users");
            List<string> users = new List<string>();
            foreach (var user in userList)
            {
                //only put the firstName in the list
                users.Add(user.GetElement("FirstName").Value.ToString());
            }
            return users;
        }
    }
}
