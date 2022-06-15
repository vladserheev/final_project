using System;
using System.Collections.Generic;

namespace final_project
{
    internal class Reader
    {
        public string Name { get; set; }
        public bool IsReading { get; set; }

        public Guid _Id { get; private set; }
        public string Pass { get; set; }
        public bool IsAdmin { get; set; }
        private List<Guid> BooksInReadingIds { get; set; }

        public Reader(string name, string pass, bool isAdmin)
        {
            Name = name;
            Pass = pass;
            IsAdmin = isAdmin;
            _Id = Guid.NewGuid();
        }
        public override string ToString()
        {
            return $"{Name} {Pass} {IsAdmin}";
        }
    }
}
