using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompareCharArrays
{
    class CompareCharArrays
    {
        static void Main()
        {
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();

            string result = "=";

            int length = Math.Min(str1.Length, str2.Length);

            for (int i = 0; i < length; i++)
            {
                if (str1[i] < str2[i])
                {
                    result = "<";
                    break;
                }
                else if (str1[i] > str2[i])
                {
                    result = ">";
                    break;
                }
                else
                {
                    if (str1.Length > str2.Length)
                    {
                        result = ">";
                    }
                    else if (str1.Length < str2.Length)
                    {
                        result = "<";
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}

