using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Striped_Towel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int length = (int)Math.Floor(n * 1.5);
            int rem1 = n % 3;
            for (int j = 0; j < length; j++)
            {
                int reminder = j % 3;
                switch (reminder)
                {
                    case 0:
                        for (int i = 0; i < (n/3); i++)
                        {
                            Console.Write("#..");
                        }
                        switch (rem1)
                        {
                            case 1:Console.Write("#");
                                break;
                            case 2:
                                Console.Write("#.");
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 1:
                        for (int i = 0; i < (n / 3); i++)
                        {
                            Console.Write("..#");
                        }
                        switch (rem1)
                        {
                            case 1:
                                Console.Write(".");
                                break;
                            case 2:
                                Console.Write("..");
                                break;
                        }
                        Console.WriteLine();
                        break;
                    case 2:
                        for (int i = 0; i < (n / 3); i++)
                        {
                            Console.Write(".#.");
                        }
                        switch (rem1)
                        {
                            case 1:
                                Console.Write(".");
                                break;
                            case 2:
                                Console.Write(".#");
                                break;
                        }
                        Console.WriteLine();
                        break;
                       
                }
            }


        }
    }
}
