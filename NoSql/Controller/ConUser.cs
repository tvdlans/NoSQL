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
            //receives a list with all users from the database
            var userList = db.LoadRecords<BsonDocument>("Users");

            List<ModUser> users = new List<ModUser>();
            foreach (var item in userList)
            {
                //creating a new user and adding all data from the database
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
                users.Add(user);
            }
            return users;
        }

        //the method that checks if all fields are empty
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

        //the method that inserts a user to the database
        public string InsertUser(string fn, string ln, string type, string email, string phonenumber, string location, bool check)
        {
            int role = GetRole(type);
            int loc = GetLoc(location);

            //checking if theres a valid email
            if (IsValidEmail(email))
            {
                //checking if the email does not already exists in the database
                if (db.LoadRecordByEmail<BsonDocument>("Users", email) == null)
                {
                    //checking if the phonenumber is valid
                    double phonenr;
                    if (Double.TryParse(phonenumber, out phonenr) && phonenumber.Length > 5 && phonenumber.Length < 14)
                    {
                        //generating a Random password
                        string password = CreatePassword(12);
                        //if the email checkbox is checked, an email is send with the generatedpassword
                        if (check == true)
                        {
                            ConSendMail sendMailObject = new ConSendMail();
                            sendMailObject.SendNewPasswordMail(email, fn + " " + ln, password);
                        }        
                        //creating a new user for the database and inserting it
                        var document = new BsonDocument
                        {
                            {"FirstName",fn},
                            {"LastName",ln},
                            {"Email",email},
                            {"Password",HashPassword(password)},
                            {"Role",role},
                            {"PhoneNumber",phonenr},
                            {"Location",loc},
                            {"NumberOfTickets",0}
                        };
                        db.InsertRecord<BsonDocument>("Users", document);
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

        //checking the location and returning the right number that corresponds with the location
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

        //checking the role and returning the right number that corresponds with the role
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

        //the method that checks if the email is valid
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

        //the method that hashes the password
        public string HashPassword(string password, string algorithm = "sha256")
        {
            return Hash(Encoding.UTF8.GetBytes(password), algorithm);
        }

        public string Hash(byte[] input, string algorithm = "sha256")
        {
            using (var hashAlgorithm = HashAlgorithm.Create(algorithm))
            {
                return Convert.ToBase64String(hashAlgorithm.ComputeHash(input));
            }
        }

        public string CreatePassword(int length)
        {
            const string valid = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890";
            StringBuilder res = new StringBuilder();
            Random rnd = new Random();
            while (0 < length--)
            {
                res.Append(valid[rnd.Next(valid.Length)]);
            }
            return res.ToString();
        }
    }
}

