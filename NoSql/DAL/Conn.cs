using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    public class Conn
    {
        private IMongoDatabase db;
        private Conn(string database)
        {
            // create the connection with the database
            var client = new MongoClient("mongodb+srv://RegUser:Welkom1234@cluster0-rpzyt.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        private static Conn instance;

        //this way the connection will be made once
        public static Conn GetInstance(string database)
        {
            if (instance == null)
            {
                instance = new Conn(database);
            }
            return instance;
        }

        // load all records
        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        // load all record that matches a certain name
        public T LoadRecordByName<T>(string table, string name)
        {
            try
            {
                var collection = db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Eq("FirstName", name);

                return collection.Find(filter).First();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        // load all record that matches a certain id
        public T LoadRecordById<T>(string table, ObjectId id)
        {
            try
            {
                var collection = db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Eq("_id", id);

                return collection.Find(filter).First();
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        // load all record that matches a certain email
        public T LoadRecordByEmail<T>(string table, string email)
        { 
            try
            {
                var collection = db.GetCollection<T>(table);
                var filter = Builders<T>.Filter.Eq("Email", email);

                return collection.Find(filter).First();

            }
            catch (Exception)
            {
                return default(T);
            }
        }

        // load all record that matches a certain incident id
        public List<T> LoadRecordByIncidentId<T>(string table, ObjectId incidentID)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("IncidentID", incidentID);

            return collection.Find(filter).ToList();
        }


        // update the password of a user in the database
        public void UpdatePassword<BsonDocument>(string table, string email, string newPassword)
        {
            var collection = db.GetCollection<BsonDocument>(table);
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            var update = Builders<BsonDocument>.Update.Set("Password", newPassword);

            collection.UpdateOne(filter, update);
        }

        // change tha status of a ticket in the database
        public void UpgradeStatusIncidents(int status,string id)
        {
            var collection = db.GetCollection<BsonDocument>("Incidents");
            var filter = Builders<BsonDocument>.Filter.Eq("_id", ObjectId.Parse(id));
            var update = Builders<BsonDocument>.Update.Set("Status", status);

            collection.UpdateOne(filter, update);
        }

        // insert a record in the database
        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
    }
}
