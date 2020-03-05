using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Driver;

namespace DAL
{
    class Conn
    {

        static void Conn1()
        {
            MongoClient dbClient = new MongoClient("");

            var database = dbClient.GetDatabase("sample_training");
            var collection = database.GetCollection<BsonDocument>("grades");
        }
    }
}
