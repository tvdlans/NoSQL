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
        ConSession conSession = new ConSession();

        //specific method to calculate the USERS finished incidents
        public int[] CalculateUsersFinishedIncidents()
        {
            //get all incidents and make a temporary incident list
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");
            List<BsonDocument> tempincidents = new List<BsonDocument>();

            //==UNNECESSARY== check for each incident if the service tag is the same as the person logged in
            //incidents = incidents.FindAll(e => e.GetElement("ServiceID").Value.AsObjectId == conSession.GetId());

            return CalculateFinishedIncidents(incidents);
        }

        //general method for calculating all the finished incidents from the parameter list
        //this is done so it could be used in the future if you need to calculate all finished incidents
        public int[] CalculateFinishedIncidents(List<BsonDocument> incidentList)
        {
            int[] incidentInformation = new int[2];

            //count each element where the resolved value is true
            int finishedIncidents = incidentList.FindAll(e => e.GetElement("Status").Value != 100).Count;
            
            //return the amount of resolved incidents and the total amount of incidents
            incidentInformation[0] = incidentList.Count;
            incidentInformation[1] = finishedIncidents;
            return incidentInformation;
        }

        public int[] CalculateIncidentsPastDeadline()
        {
            int[] incidentInformation = new int[2];

            //get all incidents and make a incident list
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");
            //filter these incidents based on status and serviceID
            incidents = incidents.FindAll(e => e.GetElement("Status").Value != 100);
            //incidents = incidents.FindAll(e => e.GetElement("ServiceID").Value.AsObjectId == conSession.GetId());
            
            //make a new list and find all incidents past deadline
            int incidentsPastDeadline = incidents.FindAll(e => e.GetElement("Date").Value.AsDateTime <= DateTime.Now).Count;

            //return the amount of resolved incidents and the total amount of incidents
            incidentInformation[0] = incidents.Count;
            incidentInformation[1] = incidentsPastDeadline;
            return incidentInformation;
        }

        public int[] CalculateTypeOfIncidents()
        {
            int[] incidentInformation = new int[3];
            int software = 0;
            int hardware = 0;
            int service = 0;

            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");

            //test for each element if it is a software, hardware or service incident
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
            //get a list of all incidents
            List<BsonDocument> incidents = db.LoadRecords<BsonDocument>("Incidents");

            //make a dictionary
            Dictionary<string, int> wordList = new Dictionary<string, int>();
            
            //create one big senctence of every incident 
            string subjects = "";
            foreach (BsonDocument incident in incidents)
            {
                subjects += " " + incident.GetElement("Subject").Value.ToString().ToLower();
            }
            //cleaning up
            subjects = subjects.Replace(",", ""); 
            subjects = subjects.Replace("!", "");
            subjects = subjects.Replace(".", "");
            subjects = subjects.Replace("?", "");
            //Create an array of words
            string[] arr = subjects.Split(' '); 

            foreach (string word in arr)
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
            incidents = incidents.FindAll(e => e.GetElement("Status").Value == 100);

            int yourIncindentCounter = 0;

            //count how many of the incidents are sovled by you
            foreach (BsonDocument incident in incidents)
            {
                if (incident.GetElement("ServiceID").Value.AsObjectId == conSession.GetId())
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
