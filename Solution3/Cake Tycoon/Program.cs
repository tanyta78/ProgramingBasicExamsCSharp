using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake_Tycoon
{
    class Program
    {
        static void Main(string[] args)
        { 
            decimal cakes = decimal.Parse(Console.ReadLine());
            decimal flourPerCake = decimal.Parse(Console.ReadLine());
            decimal flourAv = decimal.Parse(Console.ReadLine());
            decimal trufflesAmount = decimal.Parse(Console.ReadLine());
            decimal truffelsPrice = decimal.Parse(Console.ReadLine());
            decimal cakesprice = 0;
            if (flourAv>=(flourPerCake*cakes))
            {
                cakesprice = ((truffelsPrice * trufflesAmount) / cakes)*125/100;
                Console.WriteLine("All products available, price of a cake: {0:f2}", cakesprice);

            }
            else
            {
                var cakesav =Math.Floor(flourAv/flourPerCake);
                Console.WriteLine("Can make only {0} cakes, need {1:f2} kg more flour", cakesav,(cakes*flourPerCake-flourAv));
            }


        }
    }
}


