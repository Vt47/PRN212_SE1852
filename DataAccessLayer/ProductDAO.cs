using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer
{
    public class ProductDAO
    {
        static List<Product> products = new List<Product>();
        public void InitializeDataset()
        {
            products.Add(new Product { Id = 1, Name = "CoCa", Quantity = 10, Price = 999.99 });
            products.Add(new Product { Id = 2, Name = "Mana", Quantity = 5, Price = 123 });
            products.Add(new Product { Id = 3, Name = "Sti", Quantity = 7, Price = 45 });
            products.Add(new Product { Id = 4, Name = "Mirin", Quantity = 1, Price = 734 });
            products.Add(new Product { Id = 5, Name = "Pepsi", Quantity = 12, Price = 534 });
        }
        public List<Product> GetProducts()
        {
            return products;
        }
        public bool SaveProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old != null)
                return false;
            products.Add(p);
            return true;
        }
        public bool UpdateProduct(Product p)
        {
            Product old = products.FirstOrDefault(x => x.Id == p.Id);
            if (old == null)
                return false;
            old.Name = p.Name;
            old.Quantity = p.Quantity;
            old.Price = p.Price;
            return true;
        }
        public bool DeleteProduct(int id)
        {
            Product old = products.FirstOrDefault(x => x.Id == id);
            if (old == null)
                return false;
            products.Remove(old);
            return true;
        }
    }
}
