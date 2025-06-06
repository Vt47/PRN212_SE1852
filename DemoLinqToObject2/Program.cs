using System.Text;
using DemoLinqToObject2;

Console.OutputEncoding = Encoding.UTF8;
ListProduct lp = new ListProduct();
//gia lapdu lieu
lp.gen_sample_products();
Console.WriteLine("Danh sach san pham:");
lp.PrintProducts();
Console.WriteLine("Danh sach san pham co gia tu 1000 den 5000:");
lp.FilterProductByPrice(1000, 5000);
Console.WriteLine("Danh sach san pham co gia tu 1000 den 5000 sap xep giam dan:");
lp.FilterProductByPriceDesc(1000, 5000);