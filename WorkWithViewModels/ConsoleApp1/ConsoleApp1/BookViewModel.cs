﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class BookViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public BookViewModel(int id,string title)
        {
            this.Id = id;

            this.Title = title;
        }
    }
}
