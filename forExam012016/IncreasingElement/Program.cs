using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int currentnumber;
            int previosnumber=0;
            int maxlenth = 0;
            int lenth = 0;
            for (int i = 0; i < n; i++)
            {
                currentnumber = int.Parse(Console.ReadLine());
                if ((currentnumber>previosnumber)||n==0)
                {
                    lenth += 1;
                }
                else
                {
                    lenth = 1;
                }
                if (maxlenth<lenth)
                {
                    maxlenth = lenth;
                }
                previosnumber = currentnumber;
            }
            Console.WriteLine(maxlenth);
        }
    }
}
