using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using MongoDB.Bson;

namespace Controller
{
    public class ConDashboard
    {
        Conn db = Conn.GetInstance("TGGDB");

        public double CalculateFinishedIncidents()
        {
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");

            if (incidents.Count == 0)
                return 0;
            else
            {
                double resolvedCounter = 0;
                foreach (BsonDocument incident in incidents)
                {
                    if (incident.GetElement("Resolved").Value == true)
                    {
                        resolvedCounter++;
                    }
                }
                return (resolvedCounter/(double)incidents.Count)*100;
            }
        }
        public double CalculateUsersFinishedIncidents()
        {
            return 3;
        }
    }
}
