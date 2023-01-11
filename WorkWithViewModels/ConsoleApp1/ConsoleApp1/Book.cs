using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    
        public class Book
        {
            public int BookId { get; set; }
            public string Title { get; set; }
            public string AuthorName { get; set; }
            public string AuthorSurname { get; set; }
            public string PublishingHouse { get; set; }
            public int Quantity { get; set; }

            public Book(int id,string title, string authorName, string authorSurname, string publishingHouse, int quantity)
            {

            this.BookId = id;

                this.Title = title;
                this.AuthorName = authorName;
                this.AuthorSurname = authorSurname;
                this.PublishingHouse = publishingHouse;
                this.Quantity = quantity;
            }



        }
    }

