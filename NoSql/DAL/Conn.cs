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

        public void UpdatePassword<BsonDocument>(string table, string email, string newPassword)
        {
            var collection = db.GetCollection<BsonDocument>(table);
            var filter = Builders<BsonDocument>.Filter.Eq("Email", email);
            var update = Builders<BsonDocument>.Update.Set("Password", newPassword);

            collection.UpdateOne(filter, update);
        }

        public void InsertRecord<T>(string table, T record)
        {
            var collection = db.GetCollection<T>(table);
            collection.InsertOne(record);
        }

        //public static void Conn1()
        //{
        //    MongoClient dbClient = new MongoClient("mongodb+srv://RegUser:Welkom1234@cluster0-rpzyt.mongodb.net/test?retryWrites=true&w=majority");

        //    var database = dbClient.GetDatabase("TGGDB");
        //    var collection = database.GetCollection<BsonDocument>("Users");

        //    var document = collection.Find(new BsonDocument()).ToList();

        //    foreach (BsonDocument doc in document)
        //    {
        //        Console.WriteLine(doc.ToString());
        //    }
        //    Console.ReadKey();
        //}
    }
}
