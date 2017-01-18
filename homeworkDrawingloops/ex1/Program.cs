using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int lenght = (n - 1) / 2;
            Console.Write(new string('-', lenght));
            if ((n % 2) == 0)
            {

                Console.Write("**");
            }
            else
            {
                Console.Write("*");
            }

            Console.WriteLine(new string('-', lenght));

            for (int row = 1; row <= lenght; row++)
            {
                Console.Write(new string('-', lenght-row));
                Console.Write("*");
                Console.Write(new string('-', n-2*lenght+2*row-2));
                Console.Write("*");
                Console.WriteLine(new string('-', lenght-row));
            }
            int newlengh = lenght - 1;
            for (int row = newlengh; row >2; row++)
            {
                Console.Write(new string('-', row-newlengh));
                Console.Write("*");
                Console.Write(new string('-', n + 2 * newlengh - 2 * row-2));
                Console.Write("*");
                Console.WriteLine(new string('-', row-newlengh));
            }
            Console.Write(new string('-', lenght));
            if ((n % 2) == 0)
            {

                Console.Write("**");
            }
            else
            {
                Console.Write("*");
            }

            Console.WriteLine(new string('-', lenght));
        }
    }
}
