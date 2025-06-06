using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP4_Dictionary
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Dictionary<int, Product> Products { get; set; }
        public Category()
        {
            Products = new Dictionary<int, Product>();
        }
        //CRUD
        //them moi sanphamcho Category
        public void AddProduct(Product p)
        {
            if (Products.ContainsKey(p.Id) == false)
            {
                Products.Add(p.Id, p);
            }
        }
        public void PrintAllProduct()
        {
            foreach (KeyValuePair<int, Product> item in Products)
            {
                Product p = item.Value;
                Console.WriteLine(p);
            }
        }
        public Product GetProduct(int id)
        {
            if (Products.ContainsKey(id) == false)
                return null;
            return Products[id];
        }
        public Dictionary<int ,Product>SortProduct()
        {
            return  Products
                            .OrderBy(Item=>Item.Value.Price)
                            .ToDictionary<int,Product>();
        }

        public Dictionary<int, Product> ComplexSort()
        {
            return Products
                .OrderByDescending(item => item.Value.Quantity)
                .OrderBy(item => item.Value.Price)
                .ToDictionary<int, Product>();
        }

        public void EditProduct(Product p)
        {
            if (Products.ContainsKey(p.Id))
            {
                Products[p.Id] = p;
            }
            else
            {
                return;
            }
        }
        public bool DeleteProduct(int id)
        {
            if (Products.ContainsKey(Id))
            {
                return Products.Remove(id);

            }
            return false;
        }

        }
}
