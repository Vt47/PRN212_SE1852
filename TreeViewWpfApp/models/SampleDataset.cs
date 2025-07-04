using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreeViewWpfApp.models
{
    public class SampleDataset
    {
        public static Dictionary<int, Category> GenerateDataset()
        {
            Dictionary<int, Category> categories = new Dictionary<int, Category>();
            Category c1 = new Category();
            c1.Id = 1;
            c1.Name = "Laptop";

            Category c2 = new Category();
            c2.Id = 2;
            c2.Name = "TV";

            Category c3 = new Category();
            c3.Id = 3;
            c3.Name = "Phu Kien";

            categories.Add(c1.Id, c1);
            categories.Add(c2.Id, c2);
            categories.Add(c3.Id, c3);

            Product p1 = new Product() { Id = 1, Name = "Dell 1", Quantity = 10, Price = 100 };
            c1.Products.Add(p1.Id,p1);
            Product p2 = new Product() { Id = 2, Name = "Dell 2", Quantity = 20, Price = 200 };
            c1.Products.Add(p2.Id, p2);
            Product p3 = new Product() { Id = 3, Name = "Dell 3", Quantity = 30, Price = 1300 };
            c1.Products.Add(p3.Id, p3);
            Product p4 = new Product() { Id = 4, Name = "Dell 4", Quantity = 140, Price = 1400 };
            c1.Products.Add(p4.Id, p4);
            Product p5 = new Product() { Id = 5, Name = "Dell 5", Quantity = 150, Price = 1050 };
            c1.Products.Add(p5.Id, p5);

            Product p6 = new Product() { Id = 6, Name = "pana 1", Quantity = 1, Price = 10 };
            c2.Products.Add(p6.Id, p6);
            Product p7 = new Product() { Id = 7, Name = "pana 2", Quantity = 2, Price = 20 };
            c2.Products.Add(p7.Id, p7);
            Product p8 = new Product() { Id = 8, Name = "pana 3", Quantity = 3, Price = 300 };
            c2.Products.Add(p8.Id, p8);
            Product p9 = new Product() { Id = 9, Name = "pana 4", Quantity = 40, Price = 140 };
            c2.Products.Add(p9.Id, p9);
            Product p10 = new Product() { Id = 10, Name = "pana 5", Quantity = 50, Price = 150 };
            c2.Products.Add(p10.Id, p10);

            Product p11 = new Product() { Id = 11, Name = "Mouse 1", Quantity = 12, Price = 88 };
            c3.Products.Add(p11.Id, p11);
            Product p12 = new Product() { Id = 12, Name = "Mouse 2", Quantity = 25, Price = 90 };
            c3.Products.Add(p12.Id, p12);
            Product p13 = new Product() { Id = 13, Name = "Mouse 3", Quantity = 33, Price = 130 };
            c3.Products.Add(p13.Id, p13);
            Product p14 = new Product() { Id = 14, Name = "Mouse 4", Quantity = 30, Price = 140 };
            c3.Products.Add(p14.Id, p14);
            Product p15 = new Product() { Id = 15, Name = "Mouse 5", Quantity = 50, Price = 105 };
            c3.Products.Add(p15.Id, p15);

            return categories;
        }
    }
}
