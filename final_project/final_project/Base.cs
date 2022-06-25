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
        List<T> list = new List<T>();
        public void RefreshJson(T item)
        {
            
            using (StreamReader r = new StreamReader("C:/Users/Windows 10/Documents/2 семестр/ОП/final_project/final_project/final_project/"+typeof(T).Name+".json"))
            {
                string json = r.ReadToEnd();
                //list = JsonConvert.DeserializeObject<List<T>>(json);
            }
            
        }
        public Base()
        {
            Console.WriteLine("new item created " + typeof(T).Name);
        }
    }
}
