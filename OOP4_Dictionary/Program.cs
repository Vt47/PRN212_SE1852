using OOP4_Dictionary;

Category laptop = new Category();
laptop.Id = 1;
laptop.Name = "Danh muc Laptop";

Product dell1 = new Product()
{ Id = 1, Name = "Dell 1", Quantity = "10", Price = "15000000" };
laptop.AddProduct(dell1);

Product dell2 = new Product()
{ Id = 2, Name = "Dell 2", Quantity = "20", Price = "20000000" };
laptop.AddProduct(dell2);

Product dell3 = new Product()
{ Id = 3, Name = "Dell 3", Quantity = "15", Price = "17000000" };
laptop.AddProduct(dell3);

Product dell4 = new Product()
{ Id = 4, Name = "Dell 4", Quantity = "30", Price = "17000000" };
laptop.AddProduct(dell4);


Console.WriteLine("Danh sach san pham cua danh muc Laptop");
laptop.PrintAllProduct();

Console.WriteLine("Nhap id san pham can tim:");
int pid = int.Parse(Console.ReadLine());
Product p = laptop.GetProduct(pid);
if (p != null)
{
    Console.WriteLine("San pham co id = " + pid + " la:");
    Console.WriteLine(p);
}
else
{
    Console.WriteLine("Khong tim thay san pham co id = " + pid);
}

Console.WriteLine("Danh sach chua sap xep:");
laptop.PrintAllProduct();
Dictionary<int, Product> sortedProducts = laptop.SortProduct();
Console.WriteLine("Danh sach da sap xep theo gia:");
foreach (KeyValuePair<int,Product>item in sortedProducts)
{
    Product x = item.Value;
    Console.WriteLine(x);
}


Dictionary<int, Product> ComplexSort = laptop.ComplexSort();
Console.WriteLine("Danh sach da sap xep theo gia:");
foreach (KeyValuePair<int, Product> item in ComplexSort)
{
    Product x = item.Value;
    Console.WriteLine(x);
}

Product px = new Product();
px.Id = 1;
px.Name = "MAC BOOK 1000";
px.Quantity = "100";
px.Price = "1000000000";
laptop.EditProduct(px);
Console.WriteLine("Danh sach sau khi sua san pham ");
laptop.PrintAllProduct();

int pid_remove = 1;
laptop.DeleteProduct(pid_remove);
Console.WriteLine("Danh sach sau khi xoa san pham");
laptop.PrintAllProduct();
