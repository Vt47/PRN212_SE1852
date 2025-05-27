// See https://aka.ms/new-console-template for more information

using System.Text;

Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 1");
Console.WriteLine("Nhap he so a");
double a= double.Parse(Console.ReadLine());
Console.WriteLine("Nhap he so b");
double b= double.Parse(Console.ReadLine());
if (a == 0 && b == 0)
{
    Console.WriteLine("Phuong trinh vo so nghiem");
}
else if (a == 0 && b!= 0)
{
    Console.WriteLine("Phuong trinh vo nghiem");
}
else
{
    Console.WriteLine("X={0}", -b / a);
}
Console.ReadLine(); ;