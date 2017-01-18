using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Division
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double numbers = double.Parse(Console.ReadLine());
            int currentnumber= 0;
            double divToTwo = 0;
            double divToThree = 0;
            double divToFour = 0;
            for (int i = 0; i < numbers; i++)
            {
                currentnumber = int.Parse(Console.ReadLine());
                if (currentnumber%2==0)
                {
                    divToTwo += 1;
                }
                if (currentnumber%3==0)
                {
                    divToThree += 1;
                }
                if (currentnumber%4==0)
                {
                    divToFour += 1;
                }

            }
            Console.WriteLine("{0:f2}%",divToTwo * 100/numbers);
            Console.WriteLine("{0:f2}%", divToThree  * 100/numbers);
            Console.WriteLine("{0:f2}%", divToFour  * 100/numbers);


        }
    }
}
