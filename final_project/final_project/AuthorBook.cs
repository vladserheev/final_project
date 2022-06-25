using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class AuthorBook
    {
        public Guid Book_Id { get; set; }
        public Guid Author_Id { get; set; }

        public AuthorBook(Guid bookid, Guid authorid)
        {
            Book_Id=bookid;
            Author_Id=authorid;
        }
    }
}
