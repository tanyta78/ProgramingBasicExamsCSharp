using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int d1 = 1; d1 <= 9; d1++)
            {
                for (int d2 = 1; d2 <=9; d2++)
                {
                    for (int d3 = 1; d3 <=9; d3++)
                    {
                        for (int d4 = 1; d4 <= 9; d4++)
                        {
                            if ((N%d1==0)&&(N%d2==0)&&(N%d3==0)&&(N%d4==0))
                            {
                                Console.Write("{0}{1}{2}{3} ", d1, d2, d3, d4);
                            }
                        }
                    }
                }

            }
            Console.WriteLine();
        }
    }
}
