using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace final_project
{
    public partial class AdminForm : Form
    {
        Library lib = new Library();
        public AdminForm()
        {
            InitializeComponent();
            //RefreshBooksListBox();
            //RefreshReadersListBox();
        }
        private void FormLists_Load(object sender, EventArgs e)
        {
           BooksListBox.DataSource = lib.BooksList.ToList();
           ReadersListBox.DataSource = lib.ReadersList.ToList();
        }

        private void RefreshBooksListBox()
        { 
            BooksListBox.DataSource = lib.BooksList.ToList();
        }
        private void RefreshReadersListBox()
        {
            ReadersListBox.DataSource = lib.ReadersList.ToList();
        }
        private void AddBookBtn_Click(object sender, EventArgs e)
        {
            string title = BookTitleInput.Text;
            string author = BookAuthorInput.Text;
            lib.AddNewBook(title, author);
            RefreshBooksListBox();
        }
        private void AddReaderBtn_Click(object sender, EventArgs e)
        {
            string name = UserNameInput.Text;
            string pass = UserPassInput.Text;
            bool isAdmin = IsAdminCheckBox.Checked;
            lib.AddNewUser(name, pass, isAdmin);
            RefreshReadersListBox();
        }

        private void ReadersListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ReadersListBox.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersListBox.SelectedItem);
                UserNameInput.Text = reader.Name;
                UserPassInput.Text = reader.Pass;
                IsAdminCheckBox.Checked = reader.IsAdmin;

                ShowUserBooks(reader);
            }
        }

        private void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                BookTitleInput.Text = book.Title;
                BookAuthorInput.Text = book.Author;

                ShowBookReaders(book);
            }
        }

        private void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                Guid id = book._Id;
                lib.RemoveBook(id);
                RefreshBooksListBox();
            }
        }

        private void EditBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                book.Title = BookTitleInput.Text;
                book.Author = BookAuthorInput.Text;
                lib.RefreshBooksJson();
                RefreshBooksListBox();
            }
        }

  
        private void RemoveReaderBtn_Click(object sender, EventArgs e)
        {
            if (ReadersListBox.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersListBox.SelectedItem);
                Guid id = reader._Id;
                lib.RemoveReader(id);
                RefreshReadersListBox();
            }
        }

        private void EditUserBtn_Click(object sender, EventArgs e)
        {
            if (ReadersListBox.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersListBox.SelectedItem);
                reader.Name = UserNameInput.Text;
                reader.Pass = UserPassInput.Text;
                reader.IsAdmin = IsAdminCheckBox.Checked;
                lib.RefreshReadersJson();
                RefreshReadersListBox();
            }
        }

        private void ShowUserBooks (Reader reader)
        {
            Console.WriteLine(reader.Name);
            List<Book> userBookList = new List<Book>();
            foreach(Guid id in reader.BooksInReadingIds)
            {
                Console.WriteLine(id);
                userBookList.Add(lib.GetBookById(id));
            }
            UserBooksLiistBox.DataSource = userBookList.ToList();
        }

        private void ShowBookReaders(Book book)
        {
            if (book.IsOnUse == true)
            {
                List<Reader> bookReaders = new List<Reader>();
                bookReaders.Add(lib.GetUserById(book.Reader_ID));

                BookReaderListBox.DataSource = bookReaders.ToList();
            }
            else
            {
                List<string> resString = new List<string> { "Книга вільна" };
                BookReaderListBox.DataSource = resString;
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Close();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }
    }
}
