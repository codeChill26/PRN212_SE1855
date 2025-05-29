using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Customer
    {
        //cách viết POCO
        public String Id { get; set; }
        public String Name { get; set; }
        public String Email { get; set; }
        public String Address { get; set; }
        public String Phone { get; set; }
        public void PrintInfo()
        {
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Customer: Id: {Id}, Name: {Name}, Email: {Email}, Address: {Address}, Phone: {Phone}"); 
        }
    }
}
