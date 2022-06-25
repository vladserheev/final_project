using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;

namespace final_project
{
    internal class Library
    {
        public List<Book> BooksList;
        public List<Reader> ReadersList;
        public List<Author> AuthorsList;
        public List<AuthorBook> AuthorBookList;
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
                        Console.WriteLine("Readers list num");
                    }
                }
                using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/authorsDb.json"))
                {
                    string json = r.ReadToEnd();
                    AuthorsList = JsonConvert.DeserializeObject<List<Author>>(json);
                }

                using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/authorBook.json"))
                {
                    string json = r.ReadToEnd();
                    AuthorBookList = JsonConvert.DeserializeObject<List<AuthorBook>>(json);
                }
        }
        public void AddNewBook(string title, List<Guid> authors_ids)
        {
            Book book = new Book(title);
            AddNewAuthorBook(book._Id, authors_ids);
            RefreshAuthorBook();

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

        public bool RefreshAuthorBook()
        {
            try
            {
                string json = JsonConvert.SerializeObject(AuthorBookList.ToArray());
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/authorBook.json", json);
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
            reader.IsReading = true;
            book.Reader_ID = reader._Id;
            book.IsOnUse = true;
            RefreshReadersJson();
            RefreshBooksJson();
        }
        public void ReturnBookFromUser(Book book, Reader reader)
        {
            reader.Books_Ids.Remove(book._Id);
            reader.IsReading = false;
            book.Reader_ID = Guid.Empty;
            book.IsOnUse = false;
            RefreshReadersJson();
            RefreshBooksJson();
        }

        public void AddNewAuthorBook(Guid bookId, List<Guid> authorsId)
        {
            foreach(Guid id in authorsId)
            {
                AuthorBookList.Add(new AuthorBook(bookId, id));
            }
        }

        public List<Author> GetBookAuthors(Guid id)
        {
            List<Author> list = new List<Author>();
           
            List<Guid> list_ids = (List<Guid>)AuthorBookList.Where(x => x.Book_Id == id).Select(x => x.Author_Id).ToList();
            foreach(Guid Id in list_ids)
            {
                list.Add(AuthorsList.Find(x => x._Id == Id));
            }
            return list;
        }
    }
}
