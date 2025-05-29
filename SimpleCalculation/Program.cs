using System.Text;

Console.OutputEncoding=Encoding.UTF8;
void do_Calculate(double a, double b, string op)
{
    switch (op)
    {
        case "+":
            Console.WriteLine("{0}+{1}={2}", a, b, a + b);
            break;
        case "-":
            Console.WriteLine("{0}-{1}={2}", a, b, a - b);
            break;
        case "*":
            Console.WriteLine("{0}*{1}={2}", a, b, a * b);
            break;
        case "/":
            Console.WriteLine("{0}/{1}={2}", a, b, a / b);
            break;
        default:
            Console.WriteLine("Nhap lai");
            break;
    }
}
Console.WriteLine("Simple Calculation");
Console.WriteLine("Nhap a: ");
double a=Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap b: ");
double b = Double.Parse(Console.ReadLine());
Console.WriteLine("Nhap phep toan: ");
string op= Console.ReadLine();
do_Calculate(a, b, op);
Console.ReadLine();