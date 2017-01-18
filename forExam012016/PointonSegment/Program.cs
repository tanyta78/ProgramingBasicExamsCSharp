using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brics
{
    class Program
    {
        static void Main(string[] args)
        {

            var first = double.Parse(Console.ReadLine());
            var second = double.Parse(Console.ReadLine());
            var point = double.Parse(Console.ReadLine());
            if (first>second)
            {
                if ((point<=first)&&(point>=second))
                {
                    Console.WriteLine("in");
                    if ((first-point)<(point-second))
                    {
                        Console.WriteLine(first - point);
                    }
                    else
                    {
                        Console.WriteLine(point - second);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (point > second)
                    {
                        Console.WriteLine(point - first);
                    }
                    else
                    {
                        Console.WriteLine(second - point);
                    }
                }
            }
            else
            {
                if ((point >= first) && (point <= second))
                {
                    Console.WriteLine("in");
                    if ((point - first) < (second - point))
                    {
                        Console.WriteLine(point - first);
                    }
                    else
                    {
                        Console.WriteLine(second - point);
                    }
                }
                else
                {
                    Console.WriteLine("out");
                    if (point<second)
                    {
                        Console.WriteLine(first - point);
                    }
                    else
                    {
                        Console.WriteLine(point - second);
                    }
                }

            }

        }
    }
}
