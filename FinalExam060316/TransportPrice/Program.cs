using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransportPrice
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double path = double.Parse(Console.ReadLine());
            string when = Console.ReadLine();
            double taxi = 0;
            double train = 0.06 * path;
            double bus = 0.09 * path;
            double opt = 0;
            switch (when)
            {
                case "day":
                    taxi = 0.70 + 0.79 * path;
                    break;
                case "night":
                    taxi = 0.70 + 0.9 * path;
                    break;
                default:
                    break;
            }
            if (path>=100)
            {
                opt = train;
            }
            else
            {
                if (path>=20)
                {
                    if (taxi>bus)
                    {
                        opt = bus;
                    }
                    else
                    {
                        opt = taxi;
                    }
                }
                else
                {
                    opt = taxi;
                }
            }
            Console.WriteLine(opt);

        }
    }
}
