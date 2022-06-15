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
        public void SetDataFromJsonToBd()
        {
           // new Reader() { Name = "vlad", Pass = "china" };
        }

        public void BaseFirstInitialisation()
        {
            using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data1.json"))
            {
                string json = r.ReadToEnd();
                List<Book> BooksFromJson = JsonConvert.DeserializeObject<List<Book>>(json);
                BooksList = BooksFromJson;
            }

            using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/data2.json"))
            {
                string json = r.ReadToEnd();
                List<Reader> ReadersFromJson = JsonConvert.DeserializeObject<List<Reader>>(json);
                ReadersList = ReadersFromJson;
            }
        }
        public void AddNewBook(string title, string author)
        {
            Book book = new Book(title, author);
            BooksList.Add(book);
        }

        public void AddNewUser(string name, string pass, bool isAdmin)
        {
            Reader reader = new Reader(name, pass, isAdmin);
            ReadersList.Add(reader);
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
            Console.WriteLine(reader._Id);
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
    }
}
