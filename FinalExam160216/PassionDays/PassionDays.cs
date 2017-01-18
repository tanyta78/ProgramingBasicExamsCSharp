using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionDays
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal money = decimal.Parse(Console.ReadLine());
            
            string command = Console.ReadLine();
            int purchases = 0;

            while (command != "mall.Enter")
            {
                command = Console.ReadLine();
            }

            command = Console.ReadLine();

            while (command != "mall.Exit")
            {
                string actions = command;
                for (int i = 0; i < actions.Length; i++)
                {
                    decimal price = 0;
                    if (actions[i] >= 65 && actions[i] <= 90)
                    {
                        price = actions[i] * 0.5m;
                    }
                    else
                    {
                        if (actions[i] >= 97 && actions[i] <= 122)
                        {
                            price = actions[i] * 0.3m;
                        }
                        else
                        {
                            if (actions[i] == '%')
                            {
                                money = money / 2;
                            }
                            else
                            {
                                if (actions[i] == '*')
                                {
                                    money += 10;
                                }
                                else
                                {
                                    price = actions[i];
                                }
                            }
                        }
                    }
                    if ((price <= money) && (actions[i] != '*')&&(money!=0))
                    {
                        money -= price;
                        purchases++;
                    }
                    
                }
                command = Console.ReadLine();
            }
            if (purchases == 0)
            {
                Console.WriteLine("No purchases. Money left: {0:f2} lv.", money);
            }
            else
            {
                Console.WriteLine("{1} purchases. Money left: {0:f2} lv.", money, purchases);
            }
        }
    }
}
           