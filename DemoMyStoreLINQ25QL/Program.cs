using System.Text;
using DemoMyStoreLINQ25QL;

Console.OutputEncoding=Encoding.UTF8;
string connectionString = "server=localhost;database=MyStore;uid=sa;pwd=12345";
MyStoreDataContext context = new MyStoreDataContext(connectionString);
//Cau 1: dung LINQ2SQL de lay toan bo danh muc
var categories = context.Categories;
foreach (var cate in categories)
{
    Console.WriteLine(cate.CategoryID+"\t"+cate.CategoryName);
}

//cau2;tim chi tiet 1 danh muc  khi biet CategoryId
int cateid = 5;
Category category = context.Categories.FirstOrDefault(c => c.CategoryID == cateid);
if(category == null)
{
    Console.WriteLine($"Khong tim thay danh muc co ma =  {cateid}");
}
else
{
    Console.WriteLine($"Danh muc co ma = {cateid},chi tiet");
    Console.WriteLine(category.CategoryID+ "\t" + category.CategoryName);
}
//Cau 3 Them moi danh muc
/*Category cnew = new Category();
cnew.CategoryName = "Thuoc";
context.Categories.InsertOnSubmit(cnew);
context.SubmitChanges();*/
//Cau 4 : Them moi nhieu danh muc cung luc
/*List<Category> dsdm_new = new List<Category>();
dsdm_new.Add(new Category() { CategoryName = "Thuc pham" });
dsdm_new.Add(new Category() { CategoryName = "TV" });
dsdm_new.Add(new Category() { CategoryName = "Phu Kien" });
context.Categories.InsertAllOnSubmit(dsdm_new);
context.SubmitChanges();*/
//cau 5: sua danh muc
//nguyen tac : phai tim thay moi sua
Category c =( from x in context.Categories
             where x.CategoryID == 10
             select x).FirstOrDefault();
Category c2 = context.Categories.FirstOrDefault(x => x.CategoryID == 10);
if(c2 != null)
{
    c2.CategoryName = "do an";
    context.SubmitChanges();
}
//cau 6: xoa danh muc
//tim thay danh muc
Category c3 = context.Categories.FirstOrDefault(x => x.CategoryID == 12);
if (c3 != null)
{
    context.Categories.DeleteOnSubmit(c3);
    context.SubmitChanges();
}
// Cau 7: xoa tat ca danh muc ko chua bat ky san pham nao
var dsdm = from x in context.Categories
           where !x.Products.Any()
           select x;
if (dsdm.Any() )
{
    context.Categories.DeleteAllOnSubmit(dsdm);
    context.SubmitChanges();
}
else
{
    Console.WriteLine("Khong co danh muc nao khong chua san pham nao");
}