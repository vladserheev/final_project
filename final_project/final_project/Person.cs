using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Person
    {
        public string Name;
        public Guid _Id = Guid.Empty;
        public DateTime DateOfBirth = new DateTime();
        public List<Guid> Books_Ids = new List<Guid>();
    }
}
