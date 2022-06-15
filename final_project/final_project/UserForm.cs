using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace final_project
{
    public partial class UserForm : Form
    {
        Library lib = new Library();

        Reader user;
        public UserForm(Guid id)
        {
            InitializeComponent();
            Console.WriteLine(id);
            //user = lib.GetUserById(id);
            //UserNameL.Text = user.Name;
            RefreshBooksList(0);
        }

        private void RefreshBooksList(int type) // 0-показати всі книги, 1-показати тільки книги корустувача
        {
            if(type == 0)
            {
                BooksListBox.DataSource = lib.BooksList.ToList();
            }else if(type == 1)
            {
                //BooksListBox.DataSource = lib.BooksList.ToList();
                UserNameL.Text = "china";
            }
            
        }
    }
}
