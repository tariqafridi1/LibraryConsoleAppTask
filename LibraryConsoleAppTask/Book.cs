using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryConsoleAppTask
{
    internal class Book
    {
       
            public string ISBN { get; set; }
            public string Tittle { get; set; }
            public string Author { get; set; }
            public bool Available { get; set; }
            public Book(string title, string author,string isbn)
            {
                ISBN = isbn;
                Tittle = title;
                Author = author;
                //Available = avaliable;
            }
        }
    }

