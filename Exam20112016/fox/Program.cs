using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fox
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('*', i));
                Console.Write('\\');
                Console.Write(new string('-', 2 * n + 1 - 2 * i));
                Console.Write('/');
                Console.WriteLine(new string('*', i));
            }
            //to do middle part
            for (int i = 1; i <= n/3; i++)
            {
                Console.Write('|');
                Console.Write(new string('*', n/2+i-1));
                Console.Write('\\');
                Console.Write(new string('*', 2 * n +1 - 2 * i-n/2-n/2));
                Console.Write('/');
                Console.Write(new string('*', n / 2 + i-1));
                Console.WriteLine('|');
            }



            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string('-', i));
                Console.Write('\\');
                Console.Write(new string('*', 2 * n + 1 - 2 * i));
                Console.Write('/');
                Console.WriteLine(new string('-', i));
            }

        }
    }
}
