using System.Text;

Console.OutputEncoding=Encoding.UTF8;
//b1  ứng dụng out để ktra nhập hợp lệ khinaof đúng thì dừng
int n;
Console.WriteLine("Nhap n>=0" );
string s = Console.ReadLine();
if(int.TryParse(s, out n)==false)
{
    Console.WriteLine("Ban phai nhap so");
}
else
{
    if (n < 0)
    {
        Console.WriteLine("n phai >= 0");
    }
    else
    {
        int gt = 1;
        for (int i = 1; i <= n; i++)
            gt = gt * i;
        Console.WriteLine($"{n}!={gt}");
    }
}