using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AceofDiomonds
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('*', n));
            //todo middle rows
            for (int i = 0; i < (n-3)/2; i++)
            {
                Console.Write("*");
                Console.Write(new string('-', ((n-3)/2-i)));
                Console.Write(new string('@', 2*i+1));
                Console.Write(new string('-', ((n - 3) / 2 - i)));
                Console.WriteLine("*");
            }




            Console.Write("*");
            Console.Write(new string('@', n-2));
            Console.WriteLine("*");

            //todo middle rows
            for (int i = (n-3)/2-1; i >= 0; i--)
            {
                Console.Write("*");
                Console.Write(new string('-', ((n - 3) / 2 - i)));
                Console.Write(new string('@', 2 * i + 1));
                Console.Write(new string('-', ((n - 3) / 2 - i)));
                Console.WriteLine("*");
            }
            Console.WriteLine(new string('*', n));
        }
    }
}
