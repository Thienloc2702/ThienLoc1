using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    internal class Fruits
    {
        private string fruit_id, fruit_name, origin_name;
        private int price, quaility;
        public Fruits(string id, string name, string origin, int price, int quality) 
        { 
            fruit_id = id;
            fruit_name = name;
            origin_name = origin;
            this.price = price;
            this.quaility = quality;
        }

        public Fruits(string id)
        {
            fruit_id= id;   
        }
    
        public string ID { get; set; } 
        public string Name { get; set; }
        public int Price { get; set; }
    }
}
