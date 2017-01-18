using System;

namespace PoolPipes
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int V = int.Parse(Console.ReadLine());
            int p1 = int.Parse(Console.ReadLine());
            int p2 = int.Parse(Console.ReadLine());
            decimal h = decimal.Parse(Console.ReadLine());
            decimal p1fill = p1 * h;
            decimal p2fill = p2 * h;
            decimal poolfillness = p1fill + p2fill;
         
            if (poolfillness>V)
            {
                Console.WriteLine("For {0} hours the pool overflows with {1} liters.", h, poolfillness - V);
            }
            else
            {
                Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", Math.Truncate(poolfillness / V * 100), Math.Truncate(p1fill / poolfillness * 100), Math.Truncate(p2fill / poolfillness * 100));
            }

        }
    }
}
