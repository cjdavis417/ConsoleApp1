using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyName1
{
    class Program
    {
        static void Main(string[] args)
        {

            Person user = new Person();

            Console.Write("What is your name? ");
            user.Name = Console.ReadLine();

            Console.Write("How old are you? ");
            user.Age = Console.ReadLine();

            Console.Write("What is your gender? ");
            user.Gender = Console.ReadLine();

            Console.WriteLine("Hello, " + user.Name + ". " + user.Age + "???");
            Console.WriteLine("Dang, you're old, " + user.Gender + ".");

            Console.WriteLine("(press any key to end)");
            Console.ReadLine();
        }
    }
}
