using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Four_Factors
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.FG – Field Goals
            //2.FGA – Field Goal Attempts
            //3.  3P – 3 - Point Field Goals
            //4.TOV – Turnovers
            //5.ORB – Offensive Rebounds
            //6.Opp DRB – Opponent Defensive Rebounds
            //7.FT – Free Throws
            //8.FTA – Free Throw Attempts
            //•	eFG % { factor result}
            //•	TOV % { factor result}
            //•	ORB % { factor result}
            //•	FT % { factor result}
            long FG = long.Parse(Console.ReadLine());
            long FGA = long.Parse(Console.ReadLine());
            long ZP = long.Parse(Console.ReadLine());
            long TOV = long.Parse(Console.ReadLine());
            long ORB = long.Parse(Console.ReadLine());
            long OPPORB = long.Parse(Console.ReadLine());
            long FT = long.Parse(Console.ReadLine());
            long FTA = long.Parse(Console.ReadLine());
            double EFG = (double)(FG + 0.5 * ZP) / FGA;
            double TOVP = (double)TOV / (FGA + 0.44 * FTA + TOV);
            double ORBP = (double)ORB / (ORB + OPPORB);
            double FTP = (double)FT / FGA;
            Console.WriteLine("eFG% {0:f3}", EFG);
            Console.WriteLine("TOV% {0:f3}", TOVP);
            Console.WriteLine("ORB% {0:f3}", ORBP);
            Console.WriteLine("FT% {0:f3}", FTP);



        }
    }
}
