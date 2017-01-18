using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double vegeprice = double.Parse(Console.ReadLine());
            double fruitprice = double.Parse(Console.ReadLine());
            double vegekg = double.Parse(Console.ReadLine());
            double fruitkg = double.Parse(Console.ReadLine());
            double incomes = (vegekg * vegeprice + fruitkg * fruitprice)/1.94;
            Console.WriteLine(incomes);





        }
    }
}
