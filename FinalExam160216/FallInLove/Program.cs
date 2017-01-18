using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FallInLove
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                Console.Write('#');
                Console.Write(new string('~', i));
                Console.Write('#');
                Console.Write(new string('.', 2 * (N - i)));
                Console.Write('#');
                Console.Write(new string('.', 2 * i));
                Console.Write('#');
                Console.Write(new string('.', 2 * (N - i)));
                Console.Write('#');
                Console.Write(new string('~', i));
                Console.Write('#');
                Console.WriteLine();
            }
            for (int i = 1; i <= N+1; i++)
            {
                Console.Write(new string('.', 2 * i - 1));
                Console.Write('#');
                Console.Write(new string('~', N - i + 1));
                Console.Write('#');
                Console.Write(new string('.', 2 * (N - i + 1)));
                Console.Write('#');
                Console.Write(new string('~', N - i + 1));
                Console.Write('#');
                Console.Write(new string('.', 2 * i - 1));
                Console.WriteLine();
            }
            for (int i = 1; i <= N; i++)
            {
                Console.Write(new string('.',2*N+2));
                Console.Write('#');
                Console.Write('#');
                Console.Write(new string('.', 2 * N + 2));
                Console.WriteLine();
            }
        }
    }
}

