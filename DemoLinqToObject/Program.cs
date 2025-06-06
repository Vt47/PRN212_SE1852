using System.Text;

Console.OutputEncoding=Encoding.UTF8;
/*
 * Dung linqtoobject de xuat cac sochan trong danh sach
 */
int[] arr = { 100, 35, 80, 17, 22, 40, 70, 33, 18 };
//Cach 1: dung method syntax(extension method)
var even_list = arr.Where(x => x % 2 == 0);
Console.WriteLine("Cac so chan trong mang theo Method Syntax la:");
foreach (var x in even_list)
    Console.WriteLine(x+"\t");

//Cach 2: dung query syntax(cu phap tuong tu sql
var even_list2 = from x in arr
                 where x % 2 == 0
                 select x;
Console.WriteLine("Cac so chan trong mang theo Query Syntax la:");
foreach (var x in even_list2)
    Console.WriteLine(x + "\t");

/*sap xep mang tang dan va giam dan dung Method va query syntax*/
//Method
var list_asc = arr.OrderBy(x => x);
// Query
var list_asc2 = from x in arr
                orderby x
                select x;
var list_desc = from x in arr
                orderby x descending
                select x;
var list_desc2 = arr.OrderByDescending(x => x);
//Tinh tong danh sach
Console.WriteLine("Tong = " + arr.Sum());
Console.WriteLine("Dem so chan = " + arr.Where(x => x % 2 == 0).Count());