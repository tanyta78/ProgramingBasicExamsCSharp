using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareArrays
{
    class CompareArrays
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] Array1 = new int[N];
            int[] Array2 = new int[N];
            bool IsEqual = true;
            for (int i = 0; i < N; i++)
            {
                Array1[i] = int.Parse(Console.ReadLine());
               
            }
            //foreach (int item in Array1)
            //{
            //    Console.Write("{0}, ",item);
            //}
            for (int i = 0; i < N; i++)
            {
                Array2[i] = int.Parse(Console.ReadLine());

            }
            for (int i = 0; i < N; i++)
            {
                if (Array1[i]!=Array2[i])
                {
                    IsEqual = false;
                    break;
                }
            }
            if (IsEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
            

        }
    }
}
