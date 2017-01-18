using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumtoone
{
    class Program
    {
        static void Main(string[] args)
        {
            string code = Console.ReadLine();
            int sum = 0;
            for (int i = 0; i < code.Length; i++)
            {
                var letter = code[i];
                sum += letter;
            }
            int oldsum = sum;
            int number = 0;
            while (sum!=0)
            {
                number += sum % 10;
                sum = sum / 10;
                if ((sum==0)&&(number>9))
                {
                    sum = number;
                    number = 0;
                }

            }
            Console.WriteLine(number);
        }
    }
}
