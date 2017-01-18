using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Summertime_for_Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write(new string(' ', (n - 1) / 2));
            Console.Write(new string('*', n +1));
            Console.WriteLine(new string(' ', (n - 1) / 2));
            for (int i = 0; i < (n+1)/2; i++)
            {
                Console.Write(new string(' ', (n - 1) / 2));
                Console.Write('*');
                Console.Write(new string(' ', n - 1));
                Console.Write('*');
                Console.WriteLine(new string(' ', (n - 1) / 2));
            }
            if (n>3)
            {
                for (int i = 1; i <= (n-3)/2; i++)
                {
                    Console.Write(new string(' ', ((n - 1) / 2)-i));
                    Console.Write('*');
                    Console.Write(new string(' ', n - 1+2*i));
                    Console.Write('*');
                    Console.WriteLine(new string(' ', ((n - 1) / 2) - i));
                }
            }
            //to do half empty
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
                Console.Write(new string('.', 2 * n - 2));
                Console.WriteLine('*');
            }
            //to do half full
            for (int i = 0; i < n; i++)
            {
                Console.Write('*');
                Console.Write(new string('@', 2 * n - 2));
                Console.WriteLine('*');
            }
            //last row
            Console.WriteLine(new string('*', 2*n));

        }
    }
}
