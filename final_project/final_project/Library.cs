using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace final_project
{
    internal class Library
    {
        public List<Book> BooksList;
        public List<Reader> ReadersList;
        public List<Author> AuthorsList;

        public Library()
        {
            BaseFirstInitialisation();
        }
       
        public void BaseFirstInitialisation()
        {
                Console.WriteLine("first initalization");
                using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/booksDb.json"))
                {
                    string json = r.ReadToEnd();
                    BooksList = JsonConvert.DeserializeObject<List<Book>>(json);
                }
                using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/readersDb.json"))
                {
                    string json = r.ReadToEnd();
                    ReadersList = JsonConvert.DeserializeObject<List<Reader>>(json);
                    Console.WriteLine(ReadersList[0].Name);
                    if (ReadersList == null)
                    {
                        Console.WriteLine("shinnaaa");
                    }
                }
                using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/authorsDb.json"))
                {
                    string json = r.ReadToEnd();
                    AuthorsList = JsonConvert.DeserializeObject<List<Author>>(json);
                }
        }
        public void AddNewBook(string title, string author, Guid authorId)
        {
            Book book = new Book(title, author, authorId);
            BooksList.Add(book);
            RefreshBooksJson();
        }

        public Guid AddNewUser(string name, string pass, bool isAdmin)
        {
            Reader reader = new Reader(name, pass, isAdmin);
            ReadersList.Add(reader);
            RefreshReadersJson();
            return reader._Id;
        }
        public Guid AddNewAuthor(string name)
        {
            Author author = new Author(name);
            AuthorsList.Add(author);
            RefreshAuthorsJson();
            return author._Id;
        }

        public bool RemoveBook(Guid id)
        {
            try
            {
                BooksList.Remove(BooksList.Find(b => b._Id == id));
                RefreshBooksJson();
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool RemoveAuthor(Guid id)
        {
            try
            {
                AuthorsList.Remove(AuthorsList.Find(b => b._Id == id));
                RefreshAuthorsJson();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool RemoveReader(Guid id)
        {
            try
            {
                ReadersList.Remove(ReadersList.Find(b => b._Id == id));
                RefreshReadersJson();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
        public bool RefreshBooksJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(BooksList.ToArray());
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/booksDb.json", json);
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool RefreshReadersJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(ReadersList.ToArray());
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/readersDb.json", json);
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
                return false;
            }
        }

        public bool RefreshAuthorsJson()
        {
            try
            {
                string json = JsonConvert.SerializeObject(AuthorsList.ToArray());
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/authorsDb.json", json);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Reader SignIn(string username, string password)
        {
            Console.WriteLine(ReadersList[0].Name);
            Reader reader = ReadersList.Find(x => x.Name == username && x.Pass == password);
            if (reader == null)
            {
                Console.WriteLine("SignIn failed");
                return null;
            }
            else
            {
                Console.WriteLine(reader.Name);
                return reader;
            }
        }
        
        public Reader GetUserById(Guid id)
        {
            return ReadersList.Find(x => x._Id == id);
        }

        public Book GetBookById(Guid id)
        {
            return BooksList.Find(x => x._Id == id);
        }

        public void GiveBookToUser(Book book, Reader reader)
        {
            Console.WriteLine("give book");
            reader.Books_Ids.Add(book._Id);
            book.Reader_ID = reader._Id;
            book.IsOnUse = true;
            RefreshReadersJson();
            RefreshBooksJson();
        }
        public void ReturnBookFromUser(Book book, Reader reader)
        {
            reader.Books_Ids.Remove(book._Id);
            book.Reader_ID = Guid.Empty;
            book.IsOnUse = false;
            RefreshReadersJson();
            RefreshBooksJson();
        }
    }
}
