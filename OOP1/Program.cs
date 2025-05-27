using System.Text;
using OOP1;

Category c1 = new Category();
c1.Id = 1;
c1.Name = "Nuoc Mam";
Console.OutputEncoding=Encoding.UTF8;
c1.PrinInfor();

Employee emp1 = new Employee();  
/*emp1.Id = 1;
emp1.Name = "Teo";*/
// de thay doi gia tri cua thuoc tinh:
emp1.Id = 1;
emp1.Name = "Teo";
emp1.Phone = "113";
emp1.Email = "teo@gmail.com";
//de lay gia trri cua thuoc tinhs
//tu goi get cho property id
Console.WriteLine($"Employee ID={emp1.Id}");
//tu goi get cho property name
Console.WriteLine($"Employee Name = {emp1.Name}");
//hoac chung ta goi ham
emp1.PrintInfor();

//ngoai ra moi lop doi tuong co ham toString() giong java
//de tu dong trieu goi ham nay khi doi tuong xuat ra mmanhinh
Console.WriteLine("----------------");
Console.WriteLine(emp1);

//vua tao doi tuong vua khoi tao gia tri cho thuoc tinh 

Employee emp2 = new Employee(2,"Ty dai bang", "ty@yahoo.com","012345678");
Console.WriteLine(emp2);

//hoac co the coding nhuw sau
Employee emp3 = new Employee()
{
    Id = 1,
    Name = "Tun",
    Email = "tun@gmail.com",
    Phone = "567890"
};
Console.WriteLine(emp3);
