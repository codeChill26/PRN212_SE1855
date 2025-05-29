// See https://aka.ms/new-console-template for more information
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.WriteLine("Phuong trinh bac 1");
Console.WriteLine("He so a:");
double a = double.Parse(Console.ReadLine()!);
Console.WriteLine("He so b:");
double b = double.Parse(Console.ReadLine()!);
if(a==0 && b==0)
{
    Console.WriteLine("Phuong trinh co vo so nghiem");
}
else if(a==0 && b!=0)
{
    Console.WriteLine("Phuong trinh vo nghiem");
}
else
{
    double x = -b/a;
    Console.WriteLine($"Phuong trinh co 1 nghiem x = {x}");
}
Console.ReadLine();
