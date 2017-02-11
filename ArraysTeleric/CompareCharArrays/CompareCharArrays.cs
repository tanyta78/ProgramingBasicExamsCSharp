using System;

namespace CompareCharArrays
{
   public class CompareCharArrays
    {
        /// <summary>
        /// Write a program that compares two char arrays lexicographically (letter by letter).
        /// </summary>
        public static void Main()
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

