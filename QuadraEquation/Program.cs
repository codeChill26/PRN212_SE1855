using System.Text;

void first_degree_solution(double a, double b)
{
    if (a==0 & b==0)
        {
        Console.WriteLine("The equation has infinite solutions.");
    }
    else if (a==0 & b!=0)
    {
        Console.WriteLine("The equation has no solution.");
    }
    else
    {
        double x = -b / a;
        Console.WriteLine($"The solution is: {x}");
    }
}
void quadratic_equation_solution (double a, double b, double c)
{
    if (a == 0) first_degree_solution(b, c);
    else
    {
        var delta = Math.Pow(b, 2) - 4 * a * c;
        if (delta > 0)
        {
            var x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            var x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"The solutions are: {x1} and {x2}");
        }
        else if (delta == 0)
        {
            var x = -b / (2 * a);
            Console.WriteLine($"The solution is: {x}");
        }
        else
        {
            Console.WriteLine("The equation has no real solutions.");
        }
        
    }

}

    Console.OutputEncoding = Encoding.UTF8;
    Console.WriteLine("Quadration Equation:ax2+bx+c=0");
    Console.WriteLine("Hệ số a:");
    var a = double.Parse(Console.ReadLine());
    Console.WriteLine("Hệ số b:");
    var b = double.Parse(Console.ReadLine());
    Console.WriteLine("Hệ số c:");
    var c = double.Parse(Console.ReadLine());
    quadratic_equation_solution(a, b, c);
    Console.ReadLine();