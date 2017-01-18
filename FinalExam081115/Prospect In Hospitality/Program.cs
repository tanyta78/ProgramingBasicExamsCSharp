using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prospect_In_Hospitality
{
    class Program
    {
        static void Main(string[] args)
        {

           
            uint builders = uint.Parse(Console.ReadLine());
            uint receptionists = uint.Parse(Console.ReadLine());
            uint chambermaids = uint.Parse(Console.ReadLine());
            uint technicians = uint.Parse(Console.ReadLine());
            uint otherstaff = uint.Parse(Console.ReadLine());
            decimal NikiSalary = decimal.Parse(Console.ReadLine());
            decimal usacurrency = decimal.Parse(Console.ReadLine());
            decimal mysalary = decimal.Parse(Console.ReadLine());
            decimal budget = decimal.Parse(Console.ReadLine());
            decimal moneyforsalaries = builders * 1500.04m + receptionists * 2102.10m + chambermaids * 1465.46m + technicians * 2053.33m + otherstaff * 3010.98m + mysalary + NikiSalary * usacurrency;
            Console.WriteLine("The amount is: {0:f2} lv.", moneyforsalaries);
            if (moneyforsalaries>budget)
            {
                Console.WriteLine("NO \\ Need more: {0:f2} lv.", moneyforsalaries-budget);
            }
            else
            {
                Console.WriteLine("YES \\ Left: {0:f2} lv.", budget-moneyforsalaries);
            }
        }
    }
}
