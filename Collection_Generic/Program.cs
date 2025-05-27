//ung dung generic de quan ly nhanvie, thuc hien cac thao tac CRUD
//C-create - them moi
//R- Read(Retrieve)-- truy van: xem , sap xep, loc...
//U- Update -- chinh sua du lieu 
//D- Delete - xoa du lieu
//Cau 1: tao 5 nhan vien , trong do 4 fulltime, 1 partime
using System.Net.Http.Headers;
using System.Text;
using OOP2;

Console.OutputEncoding=Encoding.UTF8;   


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
    Id = 5,
    Name = "Name 5",
    IdCard = "987",
    WorkingHour = 3,
    Birthday = new DateTime(1995, 1, 1)
};
employees.Add(pe1);

// Menu system
while (true)
{
    Console.WriteLine("\n=== MENU QUẢN LÝ NHÂN VIÊN ===");
    Console.WriteLine("1. Xem danh sách nhân viên");
    Console.WriteLine("2. Sắp xếp nhân viên theo năm sinh");
    Console.WriteLine("3. Sửa thông tin nhân viên");
    Console.WriteLine("4. Xóa nhân viên");
    Console.WriteLine("5. Thoát");
    Console.Write("Chọn chức năng (1-5): ");

    if (int.TryParse(Console.ReadLine(), out int choice))
    {
        switch (choice)
        {
            case 1:
                Console.WriteLine("\nDanh sách nhân viên:");
                employees.ForEach(e => Console.WriteLine(e));
                break;
            case 2:
                SortEmployees(employees);
                Console.WriteLine("\nDanh sách sau khi sắp xếp theo năm sinh tăng dần:");
                employees.ForEach(e => Console.WriteLine(e));
                break;
            case 3:
                EditEmployee(employees);
                break;
            case 4:
                DeleteEmployee(employees);
                break;
            case 5:
                Console.WriteLine("Tạm biệt!");
                return;
            default:
                Console.WriteLine("Lựa chọn không hợp lệ!");
                break;
        }
    }
    else
    {
        Console.WriteLine("Vui lòng nhập số!");
    }
}



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

//cau 3:sap xep nhan vien theo nam sinh tang dan
static void SortEmployees(List<Employee> employees)
{
    for (int i = 0; i < employees.Count; i++)
    {
        for (int j = i + 1; j < employees.Count; j++)
        {
            Employee ei = employees[i];
            Employee ej = employees[j];
            if (ei.Birthday < ej.Birthday)
            {
                employees[i] = ej;
                employees[j] = ei;
            }
        }
    }
}




//câu 4: sửa thông tin nhân viên
  static void EditEmployee(List<Employee> employees)
{
    Console.WriteLine("\n=== Sửa thông tin nhân viên ===");
    Console.Write("Nhập mã nhân viên cần sửa: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        Employee employeeToEdit = employees.Find(e => e.Id == id);
        if (employeeToEdit != null)
        {
            Console.Write("Nhập tên mới: ");
            employeeToEdit.Name = Console.ReadLine();

            Console.Write("Nhập IdCard mới: ");
            employeeToEdit.IdCard = Console.ReadLine();

            Console.Write("Nhập ngày sinh mới (dd/MM/yyyy): ");
            if (DateTime.TryParse(Console.ReadLine(), out DateTime birthday))
            {
                employeeToEdit.Birthday = birthday;
            }

            Console.WriteLine("Đã cập nhật thông tin thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên có mã này!");
        }
    }
    else
    {
        Console.WriteLine("Mã nhân viên không hợp lệ!");
    }
}


EditEmployee(employees);

Console.WriteLine("\nDanh sách nhân viên sau khi sửa:");
employees.ForEach(e => Console.WriteLine(e));

//câu 5: xóa nhân viên
static void DeleteEmployee(List<Employee> employees)
{
    Console.WriteLine("\n=== Xóa nhân viên ===");
    Console.Write("Nhập mã nhân viên cần xóa: ");
    if (int.TryParse(Console.ReadLine(), out int id))
    {
        Employee employeeToDelete = employees.Find(e => e.Id == id);
        if (employeeToDelete != null)
        {
            employees.Remove(employeeToDelete);
            Console.WriteLine("Đã xóa nhân viên thành công!");
        }
        else
        {
            Console.WriteLine("Không tìm thấy nhân viên có mã này!");
        }
    }
    else
    {
        Console.WriteLine("Mã nhân viên không hợp lệ!");
    }
}

// Gọi hàm xóa nhân viên
DeleteEmployee(employees);

// Hiển thị danh sách sau khi xóa
Console.WriteLine("\nDanh sách nhân viên sau khi xóa:");
employees.ForEach(e => Console.WriteLine(e));

