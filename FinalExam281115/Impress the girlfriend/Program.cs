using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Impress_the_girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            uint rubles = uint.Parse(Console.ReadLine());
            uint dollars = uint.Parse(Console.ReadLine());
            uint euros = uint.Parse(Console.ReadLine());
            uint levaspecial = uint.Parse(Console.ReadLine());
           decimal levaM = decimal.Parse(Console.ReadLine());
            decimal rublesinlv = rubles * 3.50m / 100;
            decimal dollarsinlv = dollars * 1.50m;
            decimal euroinlv = euros * 1.95m;
            decimal levaspecone = levaspecial / 2;
            decimal maxPrice = Math.Max(rublesinlv,Math.Max(dollarsinlv,Math.Max(euroinlv,Math.Max(levaspecone,levaM))));
            Console.WriteLine("{0:f2}",Math.Ceiling(maxPrice));



        }
    }
}
