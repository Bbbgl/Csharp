// See https://aka.ms/new-console-template for more information

using System.Xml;

namespace ConsoleApp.Library
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("http://rss.cnn.com/rss/edition_world.rss");
            XmlNodeList itemNodes = xmlDoc.SelectNodes("//rss/channel/item");
            foreach (XmlNode itemNode in itemNodes)
            {
                XmlNode titleNode = itemNode.SelectSingleNode("title");
                XmlNode dateNode = itemNode.SelectSingleNode("pubDate");
                if ((titleNode != null) && (dateNode != null))
                    Console.WriteLine(dateNode.InnerText + ": " + titleNode.InnerText);
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
