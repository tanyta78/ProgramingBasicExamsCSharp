using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Magictrick
{
    class Program
    {
        static void Main(string[] args)
        {
            string textNum = Console.ReadLine();
                   
            int transNum = 0;
            while (transNum<10 && textNum.Length > 1)
            {
                BigInteger product = 1;
                while (textNum.Length>0)
            {
                textNum = textNum.Substring(0, textNum.Length - 1);
                    int sum = 0;
                    for (int i = 0; i < textNum.Length; i += 2)
                {
                    sum += textNum[i] - '0';
                }

                product *= sum!=0 ? sum : 1;
            }
            transNum++;
                textNum = product.ToString();

            }
            if (transNum<10)
            {
                Console.WriteLine(transNum);
            }
            Console.WriteLine(textNum);
        }
    }
}
