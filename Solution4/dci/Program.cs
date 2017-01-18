using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dci
{
    class Program
    {
        static void Main(string[] args)
        {

            //        Men: BMR = 66.5 + (13.75 x weight in kg) +(5.003 x height in cm) – (6.755 x age in years)
            //Women: BMR = 655 + (9.563 x weight in kg) +(1.850 x height in cm) – (4.676 x age in years)
            //            Number of workouts Daily Calorie Intake
           
            decimal weight = decimal.Parse(Console.ReadLine())/2.2m;
            decimal Height = decimal.Parse(Console.ReadLine())*2.54m;
            decimal age = decimal.Parse(Console.ReadLine());
           string gender = Console.ReadLine();
            decimal exercise = decimal.Parse(Console.ReadLine());
            decimal bmr = 0;
            switch (gender)
            {
                case "m":bmr = 66.5m + (13.75m*weight) + (5.003m*Height) - (6.755m*age);
                    break;
                case "f":
                    bmr = 655 + (9.563m * weight) + (1.850m * Height) - (4.676m * age);
                    break;
            }
            if (exercise<1)
            {
                bmr = bmr * 1.2m;
            }
            else
            {
                if (exercise<4)
                {
                    bmr = bmr * 1.375m;
                }
                else
                {
                    if (exercise<7)
                    {
                        bmr = bmr * 1.55m;
                    }
                    else
                    {
                        if (exercise<9)
                        {
                            bmr = bmr * 1.725m;
                        }
                        else
                        {
                            bmr = bmr * 1.9m;
                        }
                    }
                }
            }
            Console.WriteLine(Math.Floor(bmr));
        }
       
    }
}
