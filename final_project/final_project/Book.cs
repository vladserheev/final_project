using System;

namespace final_project
{
    internal class Book
    {
        public string Title { get; set; }

        public string Author { get; set; }

        public Guid _Id { get; set; }

        public Guid Reader_ID {get; set;}

        public bool IsOnUse = false;
        public Guid Author_Id { get; set; }
        public Book()
        {
            Console.WriteLine("Book created from json");
        }
        public Book(string title, string author, Guid authorId)
        {
            Console.WriteLine("BookCreated");
            Title = title;
            Author = author; 
            Author_Id = authorId;
            _Id = Guid.NewGuid();
        }

        public override string ToString()
        {
            return $"{Title}  {Author}" ;
        }
        ~Book()
        {
            Console.WriteLine("Book deleted");
        }
    }
}
