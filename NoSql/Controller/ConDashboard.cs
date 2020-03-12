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
        //make connection to the database
        Conn db = Conn.GetInstance("TGGDB");

        public int[] CalculateFinishedIncidents(List<BsonDocument> incidentList)
        {
            int[] incidentInformation = new int[2];

            //if the given list is empty, this means that no list is given create a list and add everyone to it
            if (incidentList.Count == 0)
                incidentList = db.LoadRecords<BsonDocument>("Incidents");

            //count each element where the resolved value is true
            int resolvedCounter = 0;
            foreach (BsonDocument incident in incidentList)
            {
                if (incident.GetElement("Resolved").Value == false)
                {
                    resolvedCounter++;
                }
            }
            //return the amount of resolved incidents and the total amount of incidents
            incidentInformation[0] = incidentList.Count;
            incidentInformation[1] = resolvedCounter;
            return incidentInformation;
        }
        public int[] CalculateUsersFinishedIncidents()
        {
            //get all incidents and make a temporary incident list
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");
            List<BsonDocument> tempincidents = new List<BsonDocument>();

            //check for each incident if the service tag is the same as the person logged in
            foreach (BsonDocument incident in incidents)
            {
                if (incident.GetElement("ServiceID").Value.ToString() == "5e6119c31c9d44000073cbfd")
                {
                    tempincidents.Add(incident);
                }
            }

            return CalculateFinishedIncidents(tempincidents);
        }

        public int[] CalculateIncidentsPastDeadline()
        {
            int[] incidentInformation = new int[2];

            //get all incidents and make a temporary incident list
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");
            incidents = incidents.FindAll(e => e.GetElement("Resolved").Value.ToString() == "false");
            incidents = incidents.FindAll(e => e.GetElement("ServiceID").Value.ToString() == "5e6119c31c9d44000073cbfd");

            int expiredIncidents = 0;
            foreach (BsonDocument incident in incidents)
            {
                DateTime datetime = DateTime.Parse(incident.GetElement("Date").Value.ToString());
                if (datetime <= DateTime.Now)
                {
                    expiredIncidents++;
                }
            }
            //return the amount of resolved incidents and the total amount of incidents
            incidentInformation[0] = incidents.Count;
            incidentInformation[1] = expiredIncidents;
            return incidentInformation;
        }

        public int[] CalculateTypeOfIncidents()
        {
            int[] incidentInformation = new int[3];
            int software = 0;
            int hardware = 0;
            int service = 0;

            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");

            foreach (BsonDocument incident in incidents)
            {
                switch (incident.GetElement("TypeOfIncident").Value.ToString())
                {
                    case "Software":
                        software++;
                        break;
                    case "Hardware":
                        hardware++;
                        break;
                    case "Service":
                        service++;
                        break;
                    default:
                        break;
                }
            }
            incidentInformation[0] = software;
            incidentInformation[1] = hardware;
            incidentInformation[2] = service;

            return incidentInformation;
        }

        public Dictionary<string, int> CalculateMostOccWords()
        {
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");

            Dictionary<string, int> wordList = new Dictionary<string, int>();

            string subjects = "";
            foreach (BsonDocument incident in incidents)
            {
                subjects += " " + incident.GetElement("Subject").Value.ToString().ToLower();
            }

            subjects = subjects.Replace(",", ""); //cleaning up
            subjects = subjects.Replace("!", "");
            subjects = subjects.Replace(".", "");
            subjects = subjects.Replace("?", "");
            string[] arr = subjects.Split(' '); //Create an array of words

            foreach (string word in arr) //let's loop over the words
            {
                //if it meets our criteria of at least 3 letters
                if (word.Length >= 3)
                {
                    //if it's in the dictionary increase the count
                    if (wordList.ContainsKey(word))
                        wordList[word] = wordList[word] + 1;
                    else
                        //put it in the dictionary with a count 1
                        wordList[word] = 1;
                }
            }
            return wordList;
        }

        public int[] CalculateYourIncidents()
        {
            int[] incidentInformation = new int[2];

            //get all incidents and find only the ones which are resolved
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");
            incidents = incidents.FindAll(e => e.GetElement("Resolved").Value.ToString() == "true");

            int yourIncindentCounter = 0;

            //count how many of the incidents are sovled by you
            foreach (BsonDocument incident in incidents)
            {
                if (incident.GetElement("ServiceID").Value.ToString() == "5e6119c31c9d44000073cbfd")
                {
                    yourIncindentCounter++;
                }
            }

            //return the information
            incidentInformation[0] = incidents.Count();
            incidentInformation[1] = yourIncindentCounter;
            return incidentInformation;
        }
    }
}
