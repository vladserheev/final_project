using System;
using System.Collections.Generic;

namespace final_project
{
    internal class Reader : Base<Reader>
    {
        public string Name { get; set; }
        public bool IsReading { get; set; }

        public Guid _Id { get; set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
        public List<Guid> Books_Ids { get; set; }

        public Reader()
        {
            Console.WriteLine("Reader created from json");
        }
        public Reader(string name, string pass, bool isAdmin)
        {
            Console.WriteLine("bookCreated");
            Name = name;
            Pass = pass;
            IsAdmin = isAdmin;
            Books_Ids = new List<Guid>();
           // Books_Ids.Add(Guid.NewGuid());
            _Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"{Name} {Pass} {(IsAdmin ? "Admin" : "")}";
        }

        ~Reader()
        {
            Console.WriteLine("Reader deleted!");
        }
    }
}
