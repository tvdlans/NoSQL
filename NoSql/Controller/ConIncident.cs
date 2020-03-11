using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Controller
{
    public class ConIncident
    {
        Conn db = Conn.GetInstance("TGGDB");
        public List<string> getUsers()
        {
            //get the users from the database
            var userList = db.LoadRecords<BsonDocument>("Users");
            List<string> users = new List<string>();
            foreach (var user in userList)
            {
                if(user.GetElement("Role").Value == 0)
                {
                    //only put the firstName and only employees in the list
                    users.Add(user.GetElement("FirstName").Value.ToString());
                }
                
            }
            return users;
        }
        public void insertIncident(string reported, string subject, string type, string user, string priority, string deadline, string description)
        {
            ConSession session = new ConSession();
            //get the email form the one logged in
            string email = session.GetEmail();
            //get all the info from the person who is logged in
            var userService = db.LoadRecordByEmail<BsonDocument>("Users",email);
            //get the objectid form the userServiceEmployee
            ObjectId userServiceID = userService.GetElement("_id").Value.AsObjectId;

            //get the user who was filled in into the form
            var userFile = db.LoadRecordByName<BsonDocument>("Users", user);
            //get the objectid form the employee
            ObjectId userID = userFile.GetElement("_id").Value.AsObjectId;

            DateTime newDate;
            DateTime startDate = DateTime.Now;

            //get only the numbers from the deadline
            int days = int.Parse(Regex.Match(deadline, @"\d+").Value);
            if(days == 6)
            {
                newDate = startDate.AddMonths(days);
            }
            else
            {
                newDate = startDate.AddDays(days);
            }
            var documnt = new BsonDocument
            {
                {"Reported",reported},
                {"Date",DateTime.Now},
                {"Subject",subject},
                {"EmployeeID",userID},
                {"ServiceID",userServiceID},
                {"Description",description},
                {"TypeOfIncident",type},
                {"Priority",priority},
                {"Deadline",newDate},
                {"Status",0},
                {"Resolved",false}
            };
            db.InsertRecord<BsonDocument>("Incidents", documnt);
           
        }
        public Boolean checkFields(string reported, string subject, string type, string user,string priority, string deadline, string description)
        {
            //check if everything is filled out in the form
            if (string.IsNullOrWhiteSpace(reported) || string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(priority) || string.IsNullOrWhiteSpace(deadline) || string.IsNullOrWhiteSpace(description))
            {
                return false;
            }
            else
            {
                return true;
            }

        }
    }
}
