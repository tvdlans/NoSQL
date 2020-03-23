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
        //connection to the DB
        Conn conn = Conn.GetInstance("TGGDB");

        //get the incident by ID
        public ModIncident GetIncidentById(ObjectId objectId)
        {
            //ask DAL for every incident and make objects out of them
            BsonDocument incident = conn.LoadRecordById<BsonDocument>("Incidents", objectId);
            ModIncident modIncident = new ModIncident()
            {
                Subject = incident.GetElement("Subject").Value.ToString(),
                Status = incident.GetElement("Status").Value.AsInt32,
                Resolved = incident.GetElement("Resolved").Value.AsBoolean,
                Date = incident.GetElement("Date").Value.AsDateTime,
                Deadline = incident.GetElement("Deadline").Value.AsDateTime,
                TypeOfIncident = incident.GetElement("TypeOfIncident").Value.ToString(),
                Id = incident.GetElement("_id").Value.AsObjectId
            };

            return modIncident;
        }

        //Get all comments belonging to an incident, make objects out of them and return them in a list
        public List<ModComment> GetCommentByIncidentID(ObjectId incidentID)
        {
            List<BsonDocument> commentList = conn.LoadRecordByIncidentId<BsonDocument>("Comments",incidentID);

            List<ModComment> comments = new List<ModComment>();

            foreach (BsonDocument item in commentList)
            {
                ModComment modComment = new ModComment()
                {
                    Id = item.GetElement("_id").Value.AsObjectId,
                    IcidentId = item.GetElement("IncidentID").Value.AsObjectId,
                    Comment = item.GetElement("Comment").Value.ToString()
                };
                comments.Add(modComment);
            }
            return comments;
        }
    }
}
