using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trip
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal budget = decimal.Parse(Console.ReadLine());
            string seasons = Console.ReadLine();
            string where ="";
            string type ="";
            var value = budget;
            if (seasons == "summer")
            {
                if (budget <= 100)
                {
                    value = budget*30/100;
                    where = "Bulgaria";
                    type = "Camp";
                }
                else
                {
                    if (budget <= 1000)
                    {
                        value = budget*40/100;
                        where = "Balkans";
                        type = "Camp";
                    }
                    else
                    {
                        value = budget*90/100;
                        where = "Europe";
                        type = "Hotel";
                    }
                }
            }
            else if (seasons == "winter")
            {
                if (budget <= 100)
                {
                    value = budget*70/100;
                    where = "Bulgaria";
                    type = "Hotel";
                }
                else
                {
                    if (budget <= 1000)
                    {
                        value = budget * 80 / 100;
                        where = "Balkans";
                        type = "Hotel";
                    }
                    else
                    {
                        value = budget * 90 / 100;
                        where = "Europe";
                        type = "Hotel";
                    }
                }
            }
           

            Console.WriteLine("Somewhere in {0}", where);
            Console.WriteLine("{0} - {1:0.00}", type, value);




        }
    }
}
