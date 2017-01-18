using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Ivan_Adventures
{
    class Program
    {
        static void Main(string[] args)
        {

            
            int day = int.Parse(Console.ReadLine());
            decimal BaiIvanMoney = decimal.Parse(Console.ReadLine());
            decimal alcoholwant = decimal.Parse(Console.ReadLine());
            decimal alcoholbuy = 0;
            switch (day)
            {
                case 0 :
                    alcoholbuy=BaiIvanMoney/25.0m;
                    break;
                case 1:
                    alcoholbuy = BaiIvanMoney / 21.0m;
                    break;
                case 2:
                    alcoholbuy = BaiIvanMoney / 14.0m;
                    break;
                case 3:
                    alcoholbuy = BaiIvanMoney / 17.0m;
                    break;
                case 4:
                    alcoholbuy = BaiIvanMoney / 45.0m;
                    break;
                case 5:
                    alcoholbuy = BaiIvanMoney / 59.0m;
                    break;
                case 6:
                    alcoholbuy = BaiIvanMoney / 42.0m;
                    break;
                
            }
            string condition;
            if (alcoholbuy>1.5m)
            {
                condition = "very drunk";
            }
            else
            {
                if (alcoholbuy>=1)
                {
                    condition = "drunk";
                }
                else
                {
                    condition = "sober";
                }
            }
            if (alcoholbuy>alcoholwant)
            {
                Console.WriteLine("Bai Ivan is {0} and very happy and he shared {1:f2} l. of alcohol with his friends", condition, alcoholbuy - alcoholwant);
            }
            else
            {
                if (alcoholwant==alcoholbuy)
                {
                    Console.WriteLine("Bai Ivan is {0} and happy. He is as drunk as he wanted", condition);
                }
                else
                {
                    Console.WriteLine("Bai Ivan is {0} and quite sad. He wanted to drink another {1:f2} l. of alcohol", condition,alcoholwant-alcoholbuy);
                }
            }
            
        }
    }
}
