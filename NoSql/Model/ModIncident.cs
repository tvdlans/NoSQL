using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Model
{
    public class ModIncident
    {
        [BsonId]
        public ObjectId Id { get; set; }
        public string Reported { get; set; }
        public DateTime Date { get; set; }
        [BsonId]
        public ObjectId ServiceID { get; set; }
        [BsonId]
        public ObjectId EmployeeID { get; set; }
        public string Subject { get; set; }
        public string Description { get; set; }
        public string TypeOfIncident { get; set; }
        public string Priority { get; set; }
        public DateTime Deadline { get; set; }
        public int Status { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
    }
}
