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
            var client = new MongoClient("mongodb+srv://RegUser:Welkom1234@cluster0-rpzyt.mongodb.net/test?retryWrites=true&w=majority");
            db = client.GetDatabase(database);
        }

        private static Conn instance;

        public static Conn GetInstance(string database)
        {
            if (instance == null)
            {
                instance = new Conn(database);
            }
            return instance;
        }

        public List<T> LoadRecords<T>(string table)
        {
            var collection = db.GetCollection<T>(table);
            return collection.Find(new BsonDocument()).ToList();
        }

        public T LoadRecordByName<T>(string table, string name)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("FirstName", name);

            return collection.Find(filter).First();
        }

        public T LoadRecordById<T>(string table, ObjectId id)
        {
            var collection = db.GetCollection<T>(table);
            var filter = Builders<T>.Filter.Eq("_id", id);

            return collection.Find(filter).First();
        }

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

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }
    }
}
