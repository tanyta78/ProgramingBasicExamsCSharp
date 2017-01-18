using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUcamp
{
    class Program
    {
        static void Main(string[] args)
        {
            int groups = int.Parse(Console.ReadLine());
            int peopleingroup;
            int carsPeople=0;
            int buspeople=0;
            int smallbuspeople=0;
            int bigbuspeople=0;
            int trainPeople=0;
            int allpeople = 0;
            for (int i = 0; i < groups; i++)
            {
                peopleingroup =int.Parse(Console.ReadLine());
                if (peopleingroup<=5)
                {
                    carsPeople += peopleingroup;
                }
                else
                {
                    if (peopleingroup<=12)
                    {
                        buspeople += peopleingroup;
                    }
                    else
                    {
                        if (peopleingroup<=25)
                        {
                            smallbuspeople += peopleingroup;
                        }
                        else
                        {
                            if (peopleingroup<=40)
                            {
                                bigbuspeople += peopleingroup;
                            }
                            else
                            {
                                trainPeople += peopleingroup;
                            }
                        }
                    }
                }
            }
            allpeople = carsPeople + buspeople + smallbuspeople + bigbuspeople + trainPeople;
           
            double carspers = (double) carsPeople / allpeople*100;
            double buspers = (double)buspeople / allpeople * 100;
            double smallbusspers = (double)smallbuspeople / allpeople * 100;
            double bigbuspers = (double)bigbuspeople / allpeople * 100;
            double trainpers = (double)trainPeople / allpeople * 100;
           
            Console.WriteLine("{0:f2}%",carspers);
            Console.WriteLine("{0:f2}%", buspers);
            Console.WriteLine("{0:f2}%", smallbusspers);
            Console.WriteLine("{0:f2}%", bigbuspers);
            Console.WriteLine("{0:f2}%", trainpers);


        }
    }
}
