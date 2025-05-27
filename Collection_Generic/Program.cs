//ung dung generic de quan ly nhanvie, thuc hien cac thao tac CRUD
//C-create - them moi
//R- Read(Retrieve)-- truy van: xem , sap xep, loc...
//U- Update -- chinh sua du lieu 
//D- Delete - xoa du lieu
//Cau 1: tao 5 nhan vien , trong do 4 fulltime, 1 partime
using System.Net.Http.Headers;
using System.Text;
using OOP2;

List<Employee> employees = new List<Employee>();
FulltimeEmployee fe1 = new FulltimeEmployee()
{
    Id = 1,
    Name = "Name 1",

    IdCard = "123",
    Birthday = new DateTime(1980, 1, 1)
};
employees.Add(fe1);
FulltimeEmployee fe2 = new FulltimeEmployee()
{
    Id = 2,
    Name = "Name 2",

    IdCard = "345",
    Birthday = new DateTime(1982, 1, 1)
};
employees.Add(fe2);
FulltimeEmployee fe3 = new FulltimeEmployee()
{
    Id = 3,
    Name = "Name3",

    IdCard = "456",
    Birthday = new DateTime(1983, 1, 1)
};
employees.Add(fe3);
FulltimeEmployee fe4 = new FulltimeEmployee()
{
    Id = 4,
    Name = "Name 4",

    IdCard = "789",
    Birthday = new DateTime(1984, 1, 1)
};
employees.Add(fe4);

ParttimeEmployee pe1 = new ParttimeEmployee()
{
    Id = 1,
    Name = "Name 5",
    IdCard = "987",
    WorkingHour = 3,
    Birthday = new DateTime(1995, 1, 1)
};
employees.Add(pe1);

//cau 2: xua toan bo nhan vien
Console.OutputEncoding=Encoding.UTF8;
Console.WriteLine("thong tin toan bo nhan su: ");
employees.ForEach(e => Console.WriteLine(e));

// cach 2
Console.WriteLine("--cach for thong thuong---");
foreach (var e in employees)
{
    Console.WriteLine(e);
}
//hello
//cau 3:sap xep nhan vien theo nam sinh tang dan
for (int i = 0; i < employees.Count; i++)
{
    for (int j = i+1; j < employees.Count; j++)
    {
        Employee ei = employees[i];
        Employee ej = employees[j];
        if(ei.Birthday<ej.Birthday)
        {
            employees[i] = ej;
            employees[j] = ei;
        }
    }
}

Console.WriteLine("sau khi sap xep");
employees.ForEach(e => Console.WriteLine(e));