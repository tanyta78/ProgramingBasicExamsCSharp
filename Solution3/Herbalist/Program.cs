using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herbalist
{
    class Program
    {
        static void Main(string[] args)
        {
            int ExpensesDaily = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int days = 0;
            
            int TotalIncome = 0;
            while (comand != "Season Over")
            {
                days++;
                string[] parameters = comand.Split();
                int hours = int.Parse(parameters[0]);
                string path = parameters[1];
                int price = int.Parse(parameters[2]);
                int herbs = 0;
                for (int i = 0; i < hours; i++)
                {

                    if (path[i % path.Length] == 'H')
                    {
                        herbs++;
                    }
                }
                TotalIncome = herbs * price + TotalIncome;
                comand = Console.ReadLine();
            }
            decimal IncomeDaily = (decimal)TotalIncome / days;
            if (ExpensesDaily <= IncomeDaily)
            {
                Console.WriteLine("Times are good. Extra money per day: {0:f2}.", IncomeDaily - ExpensesDaily);
            }
            else
            {
                Console.WriteLine("We are in the red. Money needed: {0}.", ExpensesDaily * days - TotalIncome);
            }
        }
    }
}


