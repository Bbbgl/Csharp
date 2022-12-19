// See https://aka.ms/new-console-template for more information

using System.Xml;

namespace ConsoleApp.Library
{
    class Program
    {
        static void Main(string[] args)
        {


            //var usernameFromUser = Console.ReadLine();

            const string path = "C:\\Users\\federico.babbini\\Desktop\\OOP\\ReadXmlCsharp\\Database.xml";

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\federico.babbini\\Desktop\\OOP\\ReadXmlCsharp\\Database.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//Library/Users/User");
            XmlNode myNode = xmlDoc.SelectSingleNode("//Library/Users");
            XmlElement newUserNode = xmlDoc.CreateElement("User", null);
            newUserNode.SetAttribute("UserId", "5");
            newUserNode.SetAttribute("Username", "pippo");
            newUserNode.SetAttribute("Password", "pippo");
            newUserNode.SetAttribute("Role", "pippo");
            myNode.AppendChild(newUserNode);
            //var nav = myNode.CreateNavigator(); 
            //nav.Attribute("user","Password",null,"ciao");
            //xmlDoc.Save("C:\\Users\\federico.babbini\\Desktop\\Database.xml");
            var userList = new List<User>();
            //var userIdDB = 0; // non riesco a fare il parse
            foreach (XmlNode userNode in userNodes)
            {
                // var userIdDB = userNode.Attributes["UserId"].ToString();
                var userIdDB = userNode.Attributes["UserId"].Value;
                var usernameDB = userNode.Attributes["Username"];
                var passwordDB = userNode.Attributes["Password"];
                var RoleDB = ConvertToERole(userNode.Attributes["Role"].Value);//non funziona

                var user = new User
                {
                    UserId = Int16.Parse(userIdDB),
                    //UserId = userIdDB,
                    Role = RoleDB,
                    Username = usernameDB.Value,
                    Password = passwordDB.Value,
                };
                userList.Add(user);
            }

            //provo a modificare un attributo

            for (var i = 0; i < userNodes.Count; i++)
            {
                if (userNodes[i].Attributes["Username"].Value =="bob")//trovo il libro con quel titolo, ho già controllato che è già presente
                {// qua dovrei fare in modo di scrivere nel database la nuova quantità
                    userNodes[i].Attributes["Username"].Value = "modyfied username";
                    break;
                }
            }



            Console.WriteLine(userList.Count);
            xmlDoc.Save("C:\\Users\\federico.babbini\\Desktop\\Database.xml");
            //Console.WriteLine(userList[0].UserId);
            //Console.WriteLine(userList[1].UserId);

            //Console.WriteLine(userList[2].Username);
            //Console.WriteLine(userList[2].UserId);

            //LoginUserCheck(usernameFromUser, userList);

            Console.WriteLine(userList[1].Role);


        }

        public static bool LoginUserCheck(string username, List<User> userListFromDb)
        {

            var check = true;
            for (int i = 0; i < userListFromDb.Count; i++)
            {
                if (username.Equals(userListFromDb[i].Username))
                {
                    // poi lo tolgo che ci sarà il controllo password
                    check = true;
                    break;

                }
                else
                {

                    check = false;

                }

            }

            if (check) { Console.WriteLine("L'utente esiste"); }
            else { Console.WriteLine("L'utente non esiste"); }
            return check;
        }

        public static eRole ConvertToERole(string role)// traduce--- converttoroleenum +++ check admin
        {
            if (role.Equals("Admin"))
            {
                return eRole.Amministratore;
            }
            else
            {
                return eRole.Utilizzatore;
            }
        }
    }



    public class User
    {

        public int UserId { get; set; }
        public string Username { get; set; }

        public string Password { get; set; }
        public eRole Role { get; set; }

    }

    public enum eRole
    {
        Amministratore,
        Utilizzatore
    }
}
