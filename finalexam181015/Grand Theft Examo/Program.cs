using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Theft_Examo
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong escapesattempt = ulong.Parse(Console.ReadLine());
            ulong sumofthieves = 0;
            ulong sumofbeers = 0;
            ulong sumslaps = 0;
            for (ulong i = 0; i < escapesattempt; i++)
            {
                ulong thieves = ulong.Parse(Console.ReadLine());
                ulong beers = ulong.Parse(Console.ReadLine());
                if (thieves>5)
                {
                    sumofthieves += thieves - 5;
                    sumofbeers += beers;
                    sumslaps += 5;
                }
                else
                {
                    sumofbeers += beers;
                    sumslaps += thieves;
                }
            }
           
            Console.WriteLine("{0} thieves slapped.", sumslaps);
            Console.WriteLine("{0} thieves escaped.", sumofthieves);
            Console.WriteLine("{0} packs, {1} bottles.",sumofbeers/6,sumofbeers%6);
        }
    }
}
