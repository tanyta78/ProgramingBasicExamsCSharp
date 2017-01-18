using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawFord
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int n = int.Parse(Console.ReadLine());
            Console.Write("/");
            Console.Write(new string('^',n/2));
            Console.Write("\\");
            Console.Write(new string('_', 2 * n - 4 - n / 2 - n / 2));
            Console.Write("/");
            Console.Write(new string('^', n/2));
            Console.Write("\\");
            Console.WriteLine();
            for (int row = 0; row < n-3; row++)
            {
                Console.Write("|");
                Console.Write(new string(' ', 2*n - 2));
                Console.Write("|");
                Console.WriteLine();
            }
            Console.Write("|");
            Console.Write(new string(' ', n / 2+1));
            Console.Write(new string('_', 2 * n - 4 - n / 2 - n / 2));
            Console.Write(new string(' ', n / 2+1));
            Console.Write("|");
            Console.WriteLine();
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.Write(new string(' ', 2 * n - 4 - n / 2 - n / 2));
            Console.Write("\\");
            Console.Write(new string('_', n / 2));
            Console.Write("/");
            Console.WriteLine();






        }
    }
}
