using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }
       
        public Guid _Id { get; set; }
        public Book()
        {
            Console.WriteLine("BookCreatedFromJson");
        }
        public Book(string title, string author)
        {
            Console.WriteLine("BookCreated");
            Title = title;
            Author = author; 
            _Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return Title + " " + Author;
        }
    }
}
