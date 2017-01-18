using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            double N1 = double.Parse(Console.ReadLine());
            double N2 = double.Parse(Console.ReadLine());
            string operanda = Console.ReadLine();
            double result = 0;
            if (operanda == "*")
            {
                result = N1 * N2;
            }
            if (operanda == "-")
            {
                result = N1 - N2;
            }
            if (operanda == "+")
            {
                result = N1 + N2;
            }
            if (operanda == "/")
            {
                if (N2 == 0)
                {
                    Console.WriteLine(" Cannot divide {0}by zero", N1);
                }
                else
                {
                    result = N1 / N2;
                    Console.WriteLine("{0} / {1} = {2:f2}", N1, N2, result);
                }
            }
            if (operanda == "%")
            {
                if (N2 == 0)
                {
                    Console.WriteLine(" Cannot divide {0} by zero", N1);
                }
                else
                {
                    result = N1 % N2;
                    Console.WriteLine("{0} % {1} = {2}", N1, N2, result);
                }
            }
            if (operanda == "*" || operanda == "+" || operanda == "-")
            {
                if (result % 2 == 0)
                {
                    Console.Write("{0} {1} {2} = {3}", N1, operanda, N2, result);
                    Console.WriteLine(" – even");
                }
                else
                {
                    Console.Write("{0} {1} {2} = {3}", N1, operanda, N2, result);
                    Console.WriteLine(" – odd");
                }
            }
        }
    }
}
