using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Firefighting_organization
{
    class Program
    {
        static void Main(string[] args)
        {
            int firefighters = int.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int kidssaved = 0;
            int adultsaved = 0;
            int seniorssaved = 0;
            
            while (comand!="rain")
            {
                int currentkids = 0;
                int currentadults = 0;
                int currentsenior = 0;
                int currentfirefighters = firefighters;
                for (int i = 0; i < comand.Length; i++)
                {
                    string parameter = comand.Substring(i, 1);
                    parameter = parameter.ToLower();
                    //Console.WriteLine(parameter);

                    switch (parameter)
                    {
                        case "k":
                            currentkids += 1;
                            break;
                        case "s":
                            currentsenior += 1;
                            break;
                        case "a":
                            currentadults += 1;
                            break;
                    }
                }
                if (currentfirefighters >= (comand.Length))
                {
                    kidssaved += currentkids;
                    adultsaved += currentadults;
                    seniorssaved += currentsenior;
                }
                else
                {
                    if (currentfirefighters >= currentkids)
                    {
                        kidssaved += currentkids;
                    }
                    else
                    {
                        kidssaved += currentfirefighters;
                        
                    }
                    currentfirefighters = currentfirefighters - currentkids;
                    if (currentfirefighters>0)
                    {
                        if (currentfirefighters>currentadults)
                        {
                            adultsaved += currentadults;
                        }
                        else
                        {
                            adultsaved += currentfirefighters;
                        }
                        currentfirefighters = currentfirefighters - currentadults;
                    }
                    if (currentfirefighters > 0)
                    {
                        seniorssaved += currentfirefighters;
                    }
                }
                comand = Console.ReadLine();
            }
            Console.WriteLine("Kids: {0}", kidssaved);
            Console.WriteLine("Adults: {0}", adultsaved);
            Console.WriteLine("Seniors: {0}", seniorssaved);
        
        }
    }
}
