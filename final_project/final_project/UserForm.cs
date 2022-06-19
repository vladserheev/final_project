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
            user = lib.GetUserById(id);
            UserNameL.Text = user.Name;
            RefreshBooksList(0);
        }

        private void RefreshBooksList(int type) // 0-показати всі книги, 1-показати тільки книги користувача
        {
            if(type == 0)
            {
                BooksListBox.DataSource = lib.BooksList.ToList();
                UserPassL.Text = "All books";
            }
            else if(type == 1)
            {
                List<Book> Userbooks = new List<Book>();
                foreach(Guid id in user.BooksInReadingIds)
                {
                    Userbooks.Add(lib.BooksList.Find(x => x._Id == id));
                }
                UserPassL.Text = "My books";
                BooksListBox.DataSource = Userbooks;
            }
            
        }
        private void ShowMyBooks_Click(object sender, EventArgs e)
        {
            RefreshBooksList(1);
        }

        private void BorrowBook_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                lib.GiveBookToUser(book, user);
            }
        }

        private void ShowAllAvailableBooks_Click(object sender, EventArgs e)
        {
            RefreshBooksList(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBook_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                lib.ReturnBook(book, user);
            }
            RefreshBooksList(1);
        }
    }
}
