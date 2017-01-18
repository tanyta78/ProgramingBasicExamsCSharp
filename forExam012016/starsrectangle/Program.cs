using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starsrectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(new string('%', 2 * n));
            int row = n-1;
            if (n%2==1)
            {
                row++;
            }
            for (int i = 0; i < row; i++)
            {
                Console.Write("%");
                Console.Write(new string(' ', n-2));
                if (i==(n-1)/2)
                {
                    Console.Write(new string('*', 2));
                }
                else
                {
                    Console.Write(new string(' ', 2));
                }
               
                Console.Write(new string(' ', n - 2));
                Console.Write("%");
                Console.WriteLine();
            }

            Console.WriteLine(new string('%', 2 * n));

        }
    }
}
