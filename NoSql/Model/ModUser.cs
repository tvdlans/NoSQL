using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Controller
{
    public class ModUser
    {
        [BsonId]
        public ObjectId ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public double PhoneNr { get; set; }
        public int Location { get; set; }
        public int NrOfTickets { get; set; }
        public int Id { get; set; }
    }
}
   