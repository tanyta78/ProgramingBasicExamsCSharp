using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaidTowel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char background = char.Parse(Console.ReadLine());
           char rhombus =char.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(background, n - i));
                Console.Write(rhombus);
                
                if (i>0)
                {
                    Console.Write(new string(background, 2 * i - 1));
                    Console.Write(rhombus);
                    Console.Write(new string(background, 2*n-2 * i - 1));
                    Console.Write(rhombus);
                    Console.Write(new string(background, 2 * i - 1));
                }
                else
                {
                    Console.Write(new string(background,2*n- 2 * i - 1));
                }
                Console.Write(rhombus);
                Console.WriteLine(new string(background, n - i));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(background, i));
                Console.Write(rhombus);
                Console.Write(new string(background, 2 * n - 2 * i - 1));
                Console.Write(rhombus);
                
                if (i > 0)
                {

                    Console.Write(new string(background, 2 * i - 1));
                    Console.Write(rhombus);
                                      
                }
               
                Console.Write(new string(background, 2 * n - 2 * i - 1));
                Console.Write(rhombus);
                Console.WriteLine(new string(background, i));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(background, n - i));
                Console.Write(rhombus);

                if (i > 0)
                {
                    Console.Write(new string(background, 2 * i - 1));
                    Console.Write(rhombus);
                    Console.Write(new string(background, 2 * n - 2 * i - 1));
                    Console.Write(rhombus);
                    Console.Write(new string(background, 2 * i - 1));
                }
                else
                {
                    Console.Write(new string(background, 2 * n - 2 * i - 1));
                }
                Console.Write(rhombus);
                Console.WriteLine(new string(background, n - i));
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(new string(background, i));
                Console.Write(rhombus);
                Console.Write(new string(background, 2 * n - 2 * i - 1));
                Console.Write(rhombus);

                if (i > 0)
                {

                    Console.Write(new string(background, 2 * i - 1));
                    Console.Write(rhombus);

                }

                Console.Write(new string(background, 2 * n - 2 * i - 1));
                Console.Write(rhombus);
                Console.WriteLine(new string(background, i));
            }
            Console.Write(new string(background, n ));
            Console.Write(rhombus);
            Console.Write(new string(background, 2 * n  - 1));
            Console.Write(rhombus);
            Console.WriteLine(new string(background, n));
        }
    }
}
