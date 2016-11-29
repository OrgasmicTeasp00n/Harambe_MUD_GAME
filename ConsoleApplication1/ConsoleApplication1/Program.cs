using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input værdi A");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input værdi B");
            int b = int.Parse(Console.ReadLine());

            

            if (b == 0)
                {
                Console.WriteLine("Kan ikke dividerer med 0");
                }
            else
                {
                Console.WriteLine(a / b);
                }

            Console.ReadLine();
        }
    }
}
