using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintingDescription
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int numberOfstudents = int.Parse(Console.ReadLine());
            int sheetsForstudent= int.Parse(Console.ReadLine());
            decimal priceOfRealm= decimal.Parse(Console.ReadLine());
            decimal amountOfmoney = ((decimal)numberOfstudents*(decimal)sheetsForstudent/500)*priceOfRealm;
            Console.WriteLine("{0:f2}",amountOfmoney);

        }
    }
}
