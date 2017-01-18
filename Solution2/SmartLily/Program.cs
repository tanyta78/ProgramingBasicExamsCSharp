using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            double priceLaundry = double.Parse(Console.ReadLine());
            double priceToy = double.Parse(Console.ReadLine());
            double money = 0;
            double toys = 0;
            for (int i = 1; i <= ageLily; i++)
            {
                if ((i%2)==0)
                {
                    money = money + (i / 2) * 10 - 1;
                }
                else
                {
                    toys += 1;
                }
            }
            money = money + (toys * priceToy);
            if (money >= priceLaundry)
            {
                Console.WriteLine("Yes! {0:f2}", money - priceLaundry);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", priceLaundry - money);
            }


        }
    }
}
