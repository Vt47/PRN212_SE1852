using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Quantity { get; set; }
        public string Price { get; set; }

         public override string ToString()
        {
            return $"{Id}\t {Name}\t{Quantity}\t {Price}";
        }
    }
}
