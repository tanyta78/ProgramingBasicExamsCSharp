using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentnumber = 0;
            int sum1 = 0;
            int sum2 = 0;
            int sum3 = 0;
            for (int i = 1; i <= n; i++)
            {
                currentnumber = int.Parse(Console.ReadLine());
                if (i % 3 == 0)
                {
                    sum3 += currentnumber;
                }
                else
                {
                    if (i % 3 == 1)
                    {
                        sum1 += currentnumber;
                    }
                    else
                    {
                        sum2 += currentnumber;
                    }
                }
            }
                Console.WriteLine("sum1 = {0}", sum1);
                Console.WriteLine("sum2 = {0}", sum2);
                Console.WriteLine("sum3 = {0}", sum3);
            
        }
    }
}
