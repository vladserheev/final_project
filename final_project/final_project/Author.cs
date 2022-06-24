using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Author
    {
        public string Name { get; set; }
        public Guid _Id { get; set; }
        public List<Guid> BooksId { get; set; }
        
        public Author()
        {
            Console.WriteLine("author created from db");
        }
        public Author(string name)
        {
            Console.WriteLine("AuthorCreated");
            Name = name;
            _Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
