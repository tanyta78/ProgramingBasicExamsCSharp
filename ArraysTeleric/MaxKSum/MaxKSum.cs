using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxKSum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int sum = 0;
            
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                

            }
            Array.Sort(numbers);
            for (int i = 0; i < K; i++)
            {
                sum += numbers[N - 1 - i];
            }
            Console.WriteLine(sum);
            
        }
    }
}
