using System.Text;

namespace FullStructureProject;
    class Program
{
    static void Main(String[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Console.WriteLine("Heakodskao");
        Console.WriteLine("Hello, World!");
        for (int i = 0; i < args.Length; i++)
        {
            Console.WriteLine(args[i]);
        }
        Console.ReadLine();
    }
}
 