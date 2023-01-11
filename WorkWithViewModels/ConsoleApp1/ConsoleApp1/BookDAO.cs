using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp1
{
    public class BookDAO
    {

        public List<Book> Read()
        {
            XmlDocument xmlDoc = new XmlDocument();
            // c'è anche XDocument
            xmlDoc.Load("C:\\Users\\federico.babbini\\Desktop\\OOP\\ReadXmlCsharp\\Database.xml");
            XmlNodeList bookNodes = xmlDoc.SelectNodes("//Library/Books/Book");
            var bookList = new List<Book>();
            foreach (XmlNode bookNode in bookNodes)
            {
                var bookIdDB = bookNode.Attributes["BookId"].Value;
                var titleDB = bookNode.Attributes["Title"];
                var authorNameDB = bookNode.Attributes["AuthorName"];
                var authorSurnameDB = bookNode.Attributes["AuthorSurname"];
                var publisherDB = bookNode.Attributes["Publisher"];
                var quantityDB = bookNode.Attributes["Quantity"].Value;
                //int quantityDBtoInt;
                //try
                //{
                //    quantityDBtoInt = Convert.ToInt32(quantityDB);

                //}catch (Exception e)
                //{
                //    quantityDBtoInt = 0;
                //}
                var book = new Book(Int32.Parse(bookIdDB),titleDB.Value, authorNameDB.Value, authorSurnameDB.Value,
                    publisherDB.Value, Int32.Parse(quantityDB));
                bookList.Add(book);


            }



            return bookList;
        }
    }
}
