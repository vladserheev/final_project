using System;
using System.Collections.Generic;
namespace final_project
{
    internal class Book
    {
        public string Title { get; set; }

        public Guid _Id { get; set; }

        public Guid Reader_ID {get; set;}

        public bool IsOnUse = false;
        public Book()
        {
            Console.WriteLine("Book created from json");
        }
        public Book(string title)
        {
            Console.WriteLine("BookCreated");
            Title = title;
            _Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{Title}" ;
        }
        ~Book()
        {
            Console.WriteLine("Book deleted");
        }
    }
}
