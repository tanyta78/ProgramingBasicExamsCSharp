using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam160216
{
    class Program
    {
        static void Main(string[] args)
        {
            
            decimal money = decimal.Parse(Console.ReadLine());
            decimal exchageRate= decimal.Parse(Console.ReadLine());
            decimal pizzaPriceLv= decimal.Parse(Console.ReadLine());
            decimal lasagnaPriceLv= decimal.Parse(Console.ReadLine());
            decimal sandwichPriceLv= decimal.Parse(Console.ReadLine());
            uint pizzaQuantity = uint.Parse(Console.ReadLine());
            uint lasagnaQuantity = uint.Parse(Console.ReadLine());
            uint sandwichQuantity = uint.Parse(Console.ReadLine());
            decimal orderGarfieldDollars = (pizzaPriceLv * pizzaQuantity + lasagnaPriceLv * lasagnaQuantity + sandwichPriceLv * sandwichQuantity)/exchageRate;
            if (orderGarfieldDollars<=money)
            {
                Console.WriteLine("Garfield is well fed, John is awesome. Money left: ${0:f2}.", money - orderGarfieldDollars);
            }
            else
            {
                Console.WriteLine("Garfield is hungry. John is a badass. Money needed: ${0:f2}.", orderGarfieldDollars - money);
            }


        }
    }
}
