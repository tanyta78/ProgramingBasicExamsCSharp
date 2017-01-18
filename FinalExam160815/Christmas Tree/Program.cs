using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write(new string('\'', n - i));
                Console.Write(new string('^', 1+2*i));
                Console.WriteLine(new string('\'', n - i));
            }
            for (int i = 1; i <= (n + 1) / 2; i++)
            {
                Console.Write(new string('\'', n - i));
                Console.Write(new string('^', 1 + 2 * i));
                Console.WriteLine(new string('\'', n - i));
            }
            for (int i = 0; i < (n + 1) / 2; i++)
            {
                Console.Write(new string('\'', n - 1));
                Console.Write("| |");
                Console.WriteLine(new string('\'', n - 1));
            }
            Console.WriteLine(new string('-', 2*n + 1));
        }
    }
}
