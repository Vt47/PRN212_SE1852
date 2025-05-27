using OOP2;
using OOP2_Reuse_as_Library;
FulltimeEmployee e1 = new FulltimeEmployee();
e1.Id = 1;
e1.Name = "Teo";
e1.Birthday = new DateTime(1960, 1, 1);
Console.WriteLine("---------thong tin Teo----------");
Console.WriteLine(e1);

Console.WriteLine("age:" + e1.TinhTuoi());