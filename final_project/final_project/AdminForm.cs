using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace final_project
{
    public partial class AdminForm : Form
    {
        Library lib = new Library();
        List<ComboBox> comboBoxes = new List<ComboBox>();
        public AdminForm()
        {
            InitializeComponent();
            RefreshBooksListBox();
            RefreshReadersListBox();
            RefreshAuthorsListBox();
        }
        public void FormLists_Load(object sender, EventArgs e)
        {
           BooksListBox.DataSource = lib.BooksList.ToList();
           ReadersListBox.DataSource = lib.ReadersList.ToList();
           AuthorsListBox.DataSource = lib.AuthorsList.ToList();
        }

        //Оновлення списків з книгами, користувачами та аторами

        public void RefreshBooksListBox()
        { 
            BooksListBox.DataSource = lib.BooksList.ToList();
        }
        public void RefreshReadersListBox()
        {
            ReadersListBox.DataSource = lib.ReadersList.ToList();
        }

        public void RefreshAuthorsListBox()
        {
            AuthorsListBox.DataSource = lib.AuthorsList.ToList();
        }

        //Додавання, редагування та видалення книг, користувачів та авторів
        public void AddBookBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem != null)
            {
                List<Guid> authors_Ids = new List<Guid>();
                authors_Ids = GetAuthorsIds(authors_Ids);
                
                Author author = ((Author)AuthorsListBox.SelectedItem);
                string title = BookTitleInput.Text;
                string author1 = BookAuthorInput.Text;
                
                lib.AddNewBook(title, author1, author._Id, authors_Ids);
                RefreshBooksListBox();
            }
        }
        public void AddReaderBtn_Click(object sender, EventArgs e)
        {
            string name = UserNameInput.Text;
            string pass = UserPassInput.Text;
            bool isAdmin = IsAdminCheckBox.Checked;
            lib.AddNewUser(name, pass, isAdmin);
            RefreshReadersListBox();
        }

        public void AddAuthorBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine("ADD BOOK");
            string name = AuthorNameInput.Text;
            lib.AddNewAuthor(name);
            RefreshAuthorsListBox();
        }

        public void EditUserBtn_Click(object sender, EventArgs e)
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

        public void EditBookBtn_Click(object sender, EventArgs e)
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

        public void EditAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem != null)
            {
                Author author = ((Author)AuthorsListBox.SelectedItem);
                author.Name = AuthorNameInput.Text;
                //lib.RefreshReadersJson();
                RefreshAuthorsListBox();
            }
        }

        public void RemoveBookBtn_Click(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                Guid id = book._Id;
                lib.RemoveBook(id);
                RefreshBooksListBox();
            }
        }

        public void RemoveReaderBtn_Click(object sender, EventArgs e)
        {
            if (ReadersListBox.SelectedItem != null)
            {
                Reader reader = ((Reader)ReadersListBox.SelectedItem);
                Guid id = reader._Id;
                lib.RemoveReader(id);
                RefreshReadersListBox();
            }
        }

        public void RemoveAuthorBtn_Click(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem != null)
            {
                Author author = ((Author)AuthorsListBox.SelectedItem);
                Guid id = author._Id;
                lib.RemoveAuthor(id);
                RefreshAuthorsListBox();
            }
        }



        // Обробники події натискання на конкретний елемент в списку
        public void ReadersListBox_SelectedIndexChanged(object sender, EventArgs e)
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

        public void BooksListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BooksListBox.SelectedItem != null)
            {
                Book book = ((Book)BooksListBox.SelectedItem);
                BookTitleInput.Text = book.Title;
                BookAuthorInput.Text = book.Author;

                ShowBookReader(book);
            }
        }

        public void AuthorsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AuthorsListBox.SelectedItem != null)
            {
                Author author = ((Author)AuthorsListBox.SelectedItem);
                AuthorNameInput.Text = author.Name;

                //BookAuthorNameInput.Text = author.Name;
            }
        }

        //Демонтрація книг які читає користувач
        private void ShowUserBooks (Reader reader)
        {
            Console.WriteLine(reader.Name);
            List<Book> userBookList = new List<Book>();
            foreach(Guid id in reader.Books_Ids)
            {
                Console.WriteLine(id);
                userBookList.Add(lib.GetBookById(id));
            }
            UserBooksLiistBox.DataSource = userBookList.ToList();
        }

        //Демонстрація користувача який читає книгу
        private void ShowBookReader(Book book)
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

        

   

        

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AuthorsCountInput.Text == "")
            {
                AuthorsCountStatusL.Text = "Поле не може бути пустим";
            }
            else if (int.Parse(AuthorsCountInput.Text) > 3 || int.Parse(AuthorsCountInput.Text) < 1)
            {
                AuthorsCountStatusL.Text = "Некоректна кількість авторів!";
            }
            else
            {
                AuthorsCountStatusL.Text = "";
                CreateComboBoxes(int.Parse(AuthorsCountInput.Text));
            }
        }

        private void CreateComboBoxes(int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Combox");
                ComboBox combox = CreateComboBox(i);
                this.Controls.Add(combox);
                comboBoxes.Add(combox);
            }
        }
        public ComboBox CreateComboBox(int i)
        {
            ComboBox combox = new ComboBox();
            combox.Location = new System.Drawing.Point(25, 342 + (i * 30));
            combox.DataSource = lib.AuthorsList.ToList();
            combox.SelectedIndexChanged += Combox_SelectedIndexChanged;
            return combox;
        }

        public void Combox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        public void LogOutBtn_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            this.Close();
        }

        public List<Guid> GetAuthorsIds(List<Guid> authorsId)
        {
            foreach(ComboBox combox in comboBoxes)
            {
                Author author = ((Author)combox.SelectedItem);
                authorsId.Add(author._Id);
            }
            return authorsId;
        }

        public void AddAuthorBtn_Click_1(object sender, EventArgs e)
        {
            Console.WriteLine("ADD BOOK");
            string name = AuthorNameInput.Text;
            lib.AddNewAuthor(name);
            RefreshAuthorsListBox();
        }
    }
}
