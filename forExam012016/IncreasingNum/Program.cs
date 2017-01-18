using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreasingNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            if ((b-a)>=3)
            {
                for (int fn = a; fn <=b; fn++)
                {
                    for (int sn = a+1; sn <= b; sn++)
                    {
                        for (int tn = a+2; tn <= b; tn++)
                        {
                            for (int fon = a+3; fon <=b; fon++)
                            {
                                if ((fn<sn)&&(sn<tn)&&(tn<fon))
                                {
                                    Console.WriteLine("{0} {1} {2} {3}", fn, sn, tn, fon);
                                }
                                
                            }
                        }
                    }
                }




            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
