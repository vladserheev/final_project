using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace final_project
{
    public class Base<T> where T : Base<T>
    {
        public static Dictionary<Guid, T> Items = new Dictionary<Guid, T>();

        public Guid Id { get; private set; }

        public Base()
        {
            //Id = Guid.NewGuid();
            //Items.Add(Id, (T)this);
            Console.WriteLine("new item created " + typeof(T).Name);
           // UpdateJson(Id, (T)this);
        }
        
        public void BaseFirstInitialisation()
        {
          
               
           // List<Book> BookList = JsonConvert.DeserializeObject<List<Book>>(json);
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Book> items = JsonConvert.DeserializeObject<List<Book>>(json);
                foreach (Book book in items)
                {
                    Console.WriteLine(book.Title);
                }
            }

           
        }

       /* public void UpdateJson(Guid id, T china)
        {
            using (StreamReader r = new StreamReader("file.json"))
            {
                string json = r.ReadToEnd();
                List<Book> items = JsonConvert.DeserializeObject<List<Book>>(json);
                foreach (Book book in items)
                {
                    Console.WriteLine(book.Title);
                }
            }
            Console.WriteLine(typeof(T).Name + " update json");
            Object JsonObj = new {
                Id= Id, 
                china
                };
            
            
            string json = JsonConvert.SerializeObject(china);
        }*/
        

        
    }
}
