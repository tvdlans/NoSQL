﻿using System;
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
        public static void Conn1()
        {
            MongoClient dbClient = new MongoClient("mongodb+srv://RegUser:Welkom1234@cluster0-rpzyt.mongodb.net/test?retryWrites=true&w=majority");

            var database = dbClient.GetDatabase("TGGDB");
            var collection = database.GetCollection<BsonDocument>("Users");

            var document = collection.Find(new BsonDocument()).ToList();

            foreach (BsonDocument doc in document)
            {
                Console.WriteLine(doc.ToString());
            }
            Console.ReadKey();
        }
    }
}
