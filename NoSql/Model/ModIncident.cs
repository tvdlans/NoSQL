using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class ModIncident
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonId]
        public ObjectId ReportedOn { get; set; }
        [BsonId]
        public ObjectId Date { get; set; }
        public string ServiceID { get; set; }
        public string EmployeeID { get; set; }
        public string Subject { get; set; }
        public int Description { get; set; }
        public string TypeOfIncident { get; set; }
        public string Priority { get; set; }
        public int Deadline { get; set; }
        public int Status { get; set; }
        public int Resolved { get; set; }
    }
}
