
void doicho(ref int a,ref int b)
{
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine("a trong ham = "+ a); Console.WriteLine("b trong ham = "+b);
}int a = 5;
int b = 7;
Console.WriteLine("a truoc khi vao ham = "+a ); Console.WriteLine("b truoc khi vao ham ="+b);
doicho(ref a,ref b);
Console.WriteLine("a sau khi vao ham = " + a); Console.WriteLine("b sau khi vao ham =" + b);