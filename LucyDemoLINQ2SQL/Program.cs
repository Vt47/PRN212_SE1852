using System.Text;
using LucyDemoLINQ2SQL;

Console.OutputEncoding=Encoding.UTF8;
string connectionString = "server=localhost;database=Lucy_SalesData;uid=sa;pwd=12345";
Lucy_SalesDataDataContext context = new Lucy_SalesDataDataContext(connectionString);
//Cau 1: xuat danh sach khach hang co mua hang
var ds1 = from c in context.Customers
          where c.Orders.Count() > 0
          select c;
Console.WriteLine("Danh sach khach hang co mua hang:");
foreach (var c in ds1)
{
    Console.WriteLine(c.CustomerID + "\t" + c.CompanyName);
}
//Cau 2: loc ra 3 khach hang mua hang nhieu nhat co gia tri don hang lon nhat cho cong ty
var ds2 = (from c in context.Customers
           join o in context.Orders on c.CustomerID equals o.CustomerID
           join od in context.Order_Details on o.OrderID equals od.OrderID
           group od by new { c.CustomerID, c.ContactName } into g
           select new
           {
               CustomerID = g.Key.CustomerID,
               ContactName = g.Key.ContactName,
               TotalAmount = g.Sum(x => x.UnitPrice * x.Quantity)
           }).OrderByDescending(x => x.TotalAmount)
             .Take(3);

foreach (var item in ds2)
{
    Console.WriteLine(item.CustomerID + "\t" + item.ContactName + "\t" + item.TotalAmount);
}