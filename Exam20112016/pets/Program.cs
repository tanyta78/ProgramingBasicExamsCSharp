using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pets
{
    class Program
    {
        static void Main(string[] args)
        {
            
           double days = double.Parse(Console.ReadLine());
            double foodskg = double.Parse(Console.ReadLine());
            double dogFooddayly = double.Parse(Console.ReadLine());
            double catFooddayly= double.Parse(Console.ReadLine());
            double turtlleFooddayly = double.Parse(Console.ReadLine());
            double neededFoods = (dogFooddayly + catFooddayly + turtlleFooddayly / 1000) * days;
            if (neededFoods>foodskg)
            {
                Console.WriteLine("{0} more kilos of food are needed.", Math.Ceiling(neededFoods - foodskg));
            }
            else
            {
                Console.WriteLine("{0} kilos of food left.", Math.Floor(foodskg- neededFoods));
            }




        }
    }
}
