using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int adults = int.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            int days= int.Parse(Console.ReadLine());
            string transport = Console.ReadLine();
            double transportcost = 0;
            double hotelcosts = days * 82.99;
            
            double sum = 0;
            switch (transport)
            {
                case "train":
                    {
                        if ((adults+students)>50)
                        {
                            transportcost = (adults * 24.99 + students * 14.99);
                        }
                        else
                        {
                            transportcost = (adults * 24.99)*2 + (students * 14.99)*2;
                        }
                    }
                    break;
                case "bus":
                    {
                        
                            transportcost = (adults * 32.50 + students * 28.50)*2;
                        
                    }
                    break;
                case "boat":
                    {
                        
                            transportcost = (adults * 42.99 + students * 39.99)  * 2;
                        
                    }
                    break;
                case "airplane":
                    {
                        
                        
                            transportcost = (adults * 70.00 + students * 50.00)  * 2;
                        
                    }
                    break; 
            }
           
            sum = (transportcost + hotelcosts) * 1.1;
            Console.WriteLine("{0:f2}",sum);




        }
    }
}
