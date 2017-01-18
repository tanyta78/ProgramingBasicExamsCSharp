using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_football_statistician
{
    class Program
    {
        static void Main(string[] args)
        {
           
            decimal payment = decimal.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            int arsenal = 0;
            int chelsea = 0;
            int mancity = 0;
            int manunt = 0;
            int leverpool = 0;
            int everton = 0;
            int southampton = 0;
            int tottenham = 0;
            int gamesplayed = 0;
            while (comand!= "End of the league.")
            {
                gamesplayed += 1;
                string [] charater = comand.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                string team1 = charater[0];
                string team2 = charater[2];
                string result = charater[1];
                switch (result)
                {
                    case "1":
                        switch (team1)
                        {
                            case "Arsenal":arsenal += 3;
                                break;
                            case "Chelsea":chelsea += 3;
                                break;
                            case "ManchesterCity":mancity += 3;
                                break;
                            case "ManchesterUnited":manunt += 3;
                                break;
                            case "Liverpool":leverpool += 3;
                                break;
                            case "Everton":everton += 3;
                                break;
                            case "Southampton":southampton += 3;
                                break;
                            case "Tottenham":tottenham += 3;
                                break;
                        }
                        break;
                    case "2":
                        switch (team2)
                        {
                            case "Arsenal":
                                arsenal += 3;
                                break;
                            case "Chelsea":
                                chelsea += 3;
                                break;
                            case "ManchesterCity":
                                mancity += 3;
                                break;
                            case "ManchesterUnited":
                                manunt += 3;
                                break;
                            case "Liverpool":
                                leverpool += 3;
                                break;
                            case "Everton":
                                everton += 3;
                                break;
                            case "Southampton":
                                southampton += 3;
                                break;
                            case "Tottenham":
                                tottenham += 3;
                                break;
                        }
                        break;
                    case "X":
                        switch (team1)
                        {
                            case "Arsenal":
                                arsenal += 1;
                                break;
                            case "Chelsea":
                                chelsea += 1;
                                break;
                            case "ManchesterCity":
                                mancity += 1;
                                break;
                            case "ManchesterUnited":
                                manunt += 1;
                                break;
                            case "Liverpool":
                                leverpool += 1;
                                break;
                            case "Everton":
                                everton += 1;
                                break;
                            case "Southampton":
                                southampton += 1;
                                break;
                            case "Tottenham":
                                tottenham += 1;
                                break;
                        }
                        switch (team2)
                        {
                            case "Arsenal":
                                arsenal += 1;
                                break;
                            case "Chelsea":
                                chelsea += 1;
                                break;
                            case "ManchesterCity":
                                mancity += 1;
                                break;
                            case "ManchesterUnited":
                                manunt += 1;
                                break;
                            case "Liverpool":
                                leverpool += 1;
                                break;
                            case "Everton":
                                everton += 1;
                                break;
                            case "Southampton":
                                southampton += 1;
                                break;
                            case "Tottenham":
                                tottenham += 1;
                                break;
                        }
                        break;
                }
                comand = Console.ReadLine();
            }
            //to do print
            //•	On the first line you should print the evaluated price for all matches in the league in leva rounded to two digits after the decimal point.
            //•	On the next 8 lines you should print all the teams in alphabetical order, each on a separate line, together with the points, they have gained.
            Console.WriteLine("{0:f2}lv.",gamesplayed*payment*1.94m);
            Console.WriteLine("Arsenal - {0} points.", arsenal);
            Console.WriteLine("Chelsea - {0} points.", chelsea);
            Console.WriteLine("Everton - {0} points.", everton);
            Console.WriteLine("Liverpool - {0} points.", leverpool);
            Console.WriteLine("Manchester City - {0} points.", mancity);
            Console.WriteLine("Manchester United - {0} points.", manunt);
            Console.WriteLine("Southampton - {0} points.", southampton);
            Console.WriteLine("Tottenham - {0} points.", tottenham);
            
        }
    }
}
