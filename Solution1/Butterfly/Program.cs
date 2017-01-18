using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 2; i < n; i++)
            {
                if (i%2==0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("\\ /");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("\\ /");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine();
                }
            }
            Console.Write(new string(' ', n-1));
            Console.Write('@');
            
            Console.WriteLine();
            for (int i = 2; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write(new string('*', n - 2));
                    Console.Write("/ \\");
                    Console.Write(new string('*', n - 2));
                    Console.WriteLine();
                }
                else
                {
                    Console.Write(new string('-', n - 2));
                    Console.Write("/ \\");
                    Console.Write(new string('-', n - 2));
                    Console.WriteLine();
                }
            }
        }
    }
}
