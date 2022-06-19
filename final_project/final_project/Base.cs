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
            Console.WriteLine("new item created " + typeof(T).Name);
        }
    }
}
