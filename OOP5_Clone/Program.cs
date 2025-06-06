using OOP5_Clone;

Customer c1 = new Customer();
c1.Id= 1;
c1.Name = "Obama";

Customer c2 = c1;
//luc nay c1 va c2 cung tro toi 1 o nho
//1 o nhoco tu  2 doi tuong tro len tro vao ==> alias
//c1  doi lam c2 doi va nguoc lai

Customer c3 = c1.copy();
//luc nay saochep toan bo du lieu tai o nho c1 dang quan ly
 