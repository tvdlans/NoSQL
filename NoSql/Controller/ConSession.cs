using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Controller
{
    public class ConSession
    {
        public void AddSession(string name, string email,ObjectId Id)
        {
            LoginInfo.UserName = name;
            LoginInfo.Email = email;
            LoginInfo.objectid = Id;
        }

        public string GetUsername()
        {
            return LoginInfo.UserName;
        }

        public string GetEmail()
        {
            return LoginInfo.Email;
        }

        public ObjectId GetId()
        {
            return LoginInfo.objectid;
        }
    }
}
