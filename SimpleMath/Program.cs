
using System.Text;

string do_math(double a, double b,string  op)
{
    string result = ""; ;
    switch(op)
    {
        case "+":
            result = a + "+" + b + "=" + (a+b);
            break;
        case "-":
            result = a + "-" +b + "=" + (a - b);
            break;
        case "*":
            result = a +"*"+ b + "=" + (a * b);
            break;
        case "/":
            if (b == 0)
                result = "mẫu số không hợp lệ";
            else
                result = a +"/" + b + "=" + (a / b);
            break;
        default:
            result = "Nhập sai";
            break;
    }
    return result;
}
Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Nhập số a");
double a = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập số b");
double b = double.Parse(Console.ReadLine());
Console.WriteLine("Nhập phép toán : +,-,*,/");
string op = Console.ReadLine();
string result = do_math(a, b, op);
Console.WriteLine(result);
Console.ReadLine();