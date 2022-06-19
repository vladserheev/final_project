using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    internal class Library
    {
        public List<Book> BooksList { get; set; }

        public List<Reader> ReadersList { get; set; }

        public Library()
        {
            BaseFirstInitialisation();
        }
       
        public void BaseFirstInitialisation()
        {
            Console.WriteLine("first initalization");
            using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data1.json"))
            {
                string json = r.ReadToEnd();
                BooksList = JsonConvert.DeserializeObject<List<Book>>(json);
            }

            using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data2.json"))
            {
                string json = r.ReadToEnd();
                ReadersList = JsonConvert.DeserializeObject<List<Reader>>(json);
            }
        }
        public void AddNewBook(string title, string author)
        {
            Book book = new Book(title, author);
            BooksList.Add(book);
        }

        public Guid AddNewUser(string name, string pass, bool isAdmin)
        {
            Reader reader = new Reader(name, pass, isAdmin);
            ReadersList.Add(reader);
            RefreshReadersJson();
            return reader._Id;
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
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data1.json", json);
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
                System.IO.File.WriteAllText("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data2.json", json);
                return true;
            }catch (Exception ex)
            {
                Console.WriteLine (ex.Message);
                return false;
            }
        }

        public Reader SignIn(string username, string password)
        {
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

        public void GiveBookToUser(Book book, Reader reader)
        {
            reader.BooksInReadingIds.Add(book._Id);
            RefreshReadersJson();
        }
        public void ReturnBookFromUser(Book book, Reader reader)
        {
            reader.BooksInReadingIds.Remove(book._Id);
            RefreshReadersJson();
        }
    }
}
