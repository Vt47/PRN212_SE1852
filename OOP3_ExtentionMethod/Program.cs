using System.Text;
using OOP3_ExtentionMethod;

Console.OutputEncoding=Encoding.UTF8;

int n1 = 5;
int n2 = 10;
Console.WriteLine("tong n1=" + n1.TongTu1ToiN());
Console.WriteLine("tong n2=" + n2.TongTu1ToiN());

int[] M = new int[10];
M.TaoMangNgauNhien();
Console.WriteLine("mang truoc khi sap xep:");
M.XuatMang();
M.SapXepTangDan();
Console.WriteLine("Mang sau khi sap xep:");
M.XuatMang();