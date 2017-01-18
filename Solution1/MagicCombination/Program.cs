using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicCombination
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int firstn = 1; firstn <= 9; firstn++)
            {
                for (int seconn = 1; seconn <=9; seconn++)
                {
                    for (int thirdn = 1; thirdn <= 9; thirdn++)
                    {
                        for (int fourtn = 1; fourtn <= 9; fourtn++)
                        {
                            for (int fifthn = 1; fifthn <= 9; fifthn++)
                            {
                                for (int sixn = 1; sixn <= 9; sixn++)
                                {
                                    if ((firstn*seconn*thirdn*fourtn*fifthn*sixn)==n)
                                    {
                                        Console.Write("{0}{1}{2}{3}{4}{5} ", firstn, seconn, thirdn, fourtn, fifthn, sixn);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine();

        }
    }
}
