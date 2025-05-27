using System.Text;
using OOP2;

Console.OutputEncoding=Encoding.UTF8;

FulltimeEmployee teo = new FulltimeEmployee();
teo.Id = 1;
teo.Name = "Teo";
Console.WriteLine(teo.calSalary());

ParttimeEmployee ty = new ParttimeEmployee();
ty.WorkingHour = 2;
ty.Name = "Ty";
ty.Id = 2;
Console.WriteLine("Luong cua ty="+ty.calSalary());

FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 100,
    Name = "Obama",
    Birthday = new DateTime(1960, 1, 25),
    IdCard = "123"
};
Console.WriteLine("=====thong tin Obama=====");
Console.WriteLine(obama);

ParttimeEmployee trump = new ParttimeEmployee() { 
Id = 200,
IdCard = "456",
Birthday = new DateTime(1940,12,26),
Name = "Trump",
WorkingHour = 3,
};
Console.WriteLine("=====thong tin Trump=====");
Console.WriteLine(trump);
