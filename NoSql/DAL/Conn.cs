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
            var filter = Builders<T>.Filter.Eq("Name", name);

            return collection.Find(filter).First();
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
