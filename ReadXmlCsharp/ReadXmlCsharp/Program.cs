using System.Xml;

namespace ConsoleApp.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("C:\\Users\\federico.babbini\\Desktop\\OOP\\ReadXmlCsharp\\Database.xml");
            XmlNodeList userNodes = xmlDoc.SelectNodes("//Library/Users/User");
            foreach (XmlNode userNode in userNodes)
            {
                Console.WriteLine(userNode.Attributes["Username"].Value);
            }
            Console.ReadKey();


            //User user = LibraryBusinessLogic.Login(username, password); //You can not invoke a non-static method from a static method.

            //XmlDocument document = new XmlDocument();
            //document.LoadXml("<People><Person Name='Nick' /><Person Name='Joe' /></People>");
            //XmlNode node = document.SelectSingleNode("/People/Person[@Name = 'Nick']");
            //Console.WriteLine(node.Attributes.ToString());

        }
    }
}
