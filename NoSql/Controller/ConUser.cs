using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Controller
{
    public class ConUser
    {
        Conn db = Conn.GetInstance("TGGDB");

        public List<ModUser> GetAllUsers()
        {
            var userList = db.LoadRecords<BsonDocument>("Users");

            List<ModUser> incidents = new List<ModUser>();
            foreach (var item in userList)
            {                
                ModUser user = new ModUser()
                {
                    FirstName = item.GetElement("FirstName").Value.ToString(),
                    LastName = item.GetElement("LastName").Value.ToString(),
                    Email = item.GetElement("Email").Value.ToString(),
                    Password = item.GetElement("Password").Value.ToString(),
                    Role = item.GetElement("Role").Value.AsInt32,
                    PhoneNr = item.GetElement("PhoneNumber").Value.AsDouble,
                    Location = item.GetElement("Location").Value.AsInt32,
                    NrOfTickets = item.GetElement("NumberOfTickets").Value.AsInt32
                };
                incidents.Add(user);
            }
            return incidents;
        }

        public bool checkFields(string fn, string ln, string type, string email, string phonenumber, string location)
        {
            if (string.IsNullOrWhiteSpace(fn) || string.IsNullOrWhiteSpace(ln) || string.IsNullOrWhiteSpace(type) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phonenumber) || string.IsNullOrWhiteSpace(location))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public string InsertUser(string fn, string ln, string type, string email, string phonenumber, string location, bool check)
        {
            int role = GetRole(type);
            int loc = GetLoc(location);

            if (IsValidEmail(email))
            {
                if (db.LoadRecordByEmail<BsonDocument>("Users", email) == null)
                {
                    double phonenr;
                    if (Double.TryParse(phonenumber, out phonenr) && phonenumber.Length>5 && phonenumber.Length<14)
                    {
                        var document = new BsonDocument
                        {
                            {"FirstName",fn},
                            {"LastName",ln},
                            {"Email",email},
                            {"Password",HashPassword("Welcome123")},
                            {"Role",role},
                            {"PhoneNumber",phonenr},
                            {"Location",loc},
                            {"NumberOfTickets",0}
                        };
                        db.InsertRecord<BsonDocument>("Users", document);
                        if (check == true)
                        {

                        }
                        return "Account created succesfully!";
                    }
                    else
                    {
                        return "Please enter a valid phone number";
                    }
                }
                else
                {
                    return "This email already exists";
                }
            }
            else
            {
                return "This is not a valid email address, please check again";
            }            
        }

        private int GetLoc(string location)
        {
            switch (location)
            {
                case "HeadQuarters":
                    return 0;
                case "Amsterdam":
                    return 1;
                case "Haarlem":
                    return 2;
                case "Knupperdam":
                    return 3;
                default:
                    return 0;
            }
        }

        private int GetRole(string type)
        {
            switch (type)
            {
                case "Employee":
                    return 0;
                case "Service Desk Employee":
                    return 1;
                default:
                    return 0;
            }
        }

        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private static string HashPassword(string password, string algorithm = "sha256")
        {
            return Hash(Encoding.UTF8.GetBytes(password), algorithm);
        }

        private static string Hash(byte[] input, string algorithm = "sha256")
        {
            using (var hashAlgorithm = HashAlgorithm.Create(algorithm))
            {
                return Convert.ToBase64String(hashAlgorithm.ComputeHash(input));
            }
        }
    }
}
