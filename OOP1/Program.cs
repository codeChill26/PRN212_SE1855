using OOP1;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
//Tạo mootjt đối tượng danh mục :
Category c1 = new Category();
//gọi hàm xuất dữ liệu:
c1.Id = 1;
c1.Name = "Thực phẩm";
c1.PrintInfo();

//Khởi tạo 1 Nhân viên :
Employees e1 = new Employees(); 
e1.Id = 1;//gọi setter id
e1.IdCard = "123456789";//gọi setter id_card
e1.Name = "Phuc";//gọi setter name
e1.Email = "hell@gmail.com";//gọi setter email
e1.Phone = "0123456789";//gọi setter phone
//gọi hàm xuất thông tin :
e1.PrintInfo();
//Ta có thể truy suất theo từng property để lấy giá trị của thuộc tính
Console.WriteLine("------------------");
Console.WriteLine("Id của e1="+e1.Id);//gọi getter property id
Console.WriteLine($"Name của e1 {e1.Name}");//gọi getter property name

//Ta cũng có thể khởi tạo đối tượng và các giá trị của thuộc tinh như sau:
Employees e2 = new Employees()
{
    Id = 2,
    IdCard = "123456789",
    Name = "Phuc",
    Email = "hell@gmails.com",
    Phone = "0987654321"
};
Console.WriteLine("------------------");
e2.PrintInfo();

Console.WriteLine("------------------");
Employees e3 = new Employees(3, "123456789", "Phuc", "mail", "0123456789");
//gọi hàm xuất tt
e3.PrintInfo();
//hoặc tự động gọi toString() khi in ra console
Console.WriteLine(e3);

//tạo đối tượng customer:
Customer cus1 = new Customer()
{
    Id = "C001",
    Name = "Nguyễn Văn A",
    Email = "đhd@gmail.com",
    Address = " eheje",
    Phone = "0123456789"
};
cus1.PrintInfo();   
cus1.Name = "Nguyễn Văn B";
cus1.Phone = "0987654321";
cus1.PrintInfo();