using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hello");
            Console.WriteLine("hello2");
            Class2 cs2 = new Class2();
            cs2.Run();
            Console.WriteLine("hello3");
            var c = new Class1();
            c.Write();
        }
    }
}
