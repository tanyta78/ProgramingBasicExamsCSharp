using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace LoopsTA
{
    class Program
    {
        static void Main()
        {

           
            int N = int.Parse(Console.ReadLine());
           
            BigInteger result = 1;
            BigInteger fact1 = 1;
            BigInteger fact2 = 1;
            for (int i = N+1; i <= 2*N; i++)
            {
                fact1 = fact1 * i;
            }
            for (int i = 1; i <= N+1; i++)
            {
                fact2 = fact2 * i;
            }
            result = fact1 / fact2;
                       Console.WriteLine(result);
        }
    }
}
        
