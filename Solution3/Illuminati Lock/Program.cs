using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Illuminati_Lock
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.Write(new string('.', n));
            Console.WriteLine();
            Console.Write(new string('.', n-2));
            Console.Write(new string('#', 3));
            Console.Write(new string('.', n-2));
            Console.Write(new string('#', 3));
            Console.Write(new string('.', n-2));
            Console.WriteLine();
            for (int i = 2; i <= (n/2); i++)
            {
                Console.Write(new string('.', n - 2*i));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', 2*i - 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', n - 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 2 * i - 2));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', n - 2 * i));
                Console.WriteLine();
                
            }
            for (int i = n/2; i >= 2; i--)
            {
                Console.Write(new string('.', n - 2 * i));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', 2 * i - 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', n - 2));
                Console.Write(new string('#', 1));
                Console.Write(new string('.', 2 * i - 2));
                Console.Write(new string('#', 2));
                Console.Write(new string('.', n - 2 * i));
                Console.WriteLine();
            }
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 3));
            Console.Write(new string('.', n - 2));
            Console.Write(new string('#', 3));
            Console.Write(new string('.', n - 2));
            Console.WriteLine();
            Console.Write(new string('.', n));
            Console.Write(new string('#', n));
            Console.Write(new string('.', n));
            Console.WriteLine();
        }
    }
}
