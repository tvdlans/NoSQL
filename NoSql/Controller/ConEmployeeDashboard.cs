using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;

namespace Controller
{
    public class ConEmployeeDashboard
    {
        Conn conn = Conn.GetInstance("TGGDB");

        public ModIncident GetIncidentById(ObjectId objectId)
        {
            var incident = conn.LoadRecordById<BsonDocument>("Incident", objectId);
            ModIncident modIncident = new ModIncident()
            {
                Name = user.GetElement("FirstName").Value.ToString(),
                Subject = item.GetElement("Subject").Value.ToString(),
                Status = item.GetElement("Status").Value.AsInt32,
                Resolved = item.GetElement("Resolved").Value.AsBoolean,
                Date = item.GetElement("Date").Value.AsDateTime,
                Deadline = item.GetElement("Deadline").Value.AsDateTime,
                TypeOfIncident = item.GetElement("TypeOfIncident").Value.ToString(),
                Id = item.GetElement("_id").Value.AsObjectId
            };

            return modIncident;
        }
    }
}
