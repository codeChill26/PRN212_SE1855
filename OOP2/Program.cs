using OOP2;
using System.Text;

Console.OutputEncoding=Encoding.UTF8;
FulltimeEmployee obama = new FulltimeEmployee()
{
    Id = 1,
    IdCard = "123",
    Name = "Barac Obama",
    Birthday = new DateTime(1960, 11, 25)
};
Console.WriteLine("---Thông tin của OBAMA---");
Console.WriteLine($"Id={obama.Id}");
Console.WriteLine("Name="+obama.Name);
Console.WriteLine("IdCard=" + obama.IdCard);
Console.WriteLine("Năm sinh=" + 
                        obama.Birthday.ToString("dd/MM/yyy"));
Console.WriteLine("Mức lương Obama nhận = "+obama.calSalary());

ParttimeEmployee trump = new ParttimeEmployee();
trump.Id = 2;
trump.Name = "Donald Trump";
trump.IdCard = "456";
trump.Birthday = new DateTime(1959, 11, 27);
trump.WorkingHour = 3;

Console.WriteLine("---Thông tin của TRUMP---");
Console.WriteLine($"Id={trump.Id}");
Console.WriteLine("Name=" + trump.Name);
Console.WriteLine("IdCard=" + trump.IdCard);
Console.WriteLine("Năm sinh=" +
                        trump.Birthday.ToString("dd/MM/yyy"));
Console.WriteLine("Mức lương TRUMP nhận = " + trump.calSalary());

Console.WriteLine("----Sử dụng toString()----");
Console.WriteLine(obama);
Console.WriteLine(trump);