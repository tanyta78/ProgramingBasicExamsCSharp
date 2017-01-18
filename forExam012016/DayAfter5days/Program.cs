using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayAfter5days
{
    class Program
    {
        static void Main(string[] args)
        {
            int day = int.Parse(Console.ReadLine());
            int mounth = int.Parse(Console.ReadLine());
            switch (mounth)
            {
                case 2:
                    if ((day+5)>28)
                    {
                        mounth += 1;
                        day = day + 5 - 28;
                    }
                    else
                    {
                        day = day + 5;
                    }
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    if ((day + 5) > 30)
                    {
                        mounth += 1;
                        day = day + 5 - 30;
                    }
                    else
                    {
                        day = day + 5;
                    }
                    break;
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    if ((day + 5) > 31)
                    {
                        mounth += 1;
                        day = day + 5 - 31;
                    }
                    else
                    {
                        day = day + 5;
                    }
                    if (mounth>12)
                    {
                        mounth = mounth - 12;
                    }
                    break;
            }
            Console.WriteLine("{0}.{1:00}", day, mounth);


        }
    }
}
