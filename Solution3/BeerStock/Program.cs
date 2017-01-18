using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerStock
{
    class Program
    {
        static void Main(string[] args)
        {
            long resBeers = long.Parse(Console.ReadLine());
            string comand = Console.ReadLine();
            long beers = 0;
            while (comand != "Exam Over")
            {
                string[] parameters = comand.Split();
                long amount = long.Parse(parameters[0]);
                //beers”, ”sixpacks”, ”cases”.
                string type = parameters[1];
                switch (type)
                {
                    case "beers":beers += amount * 1;
                        break;
                    case "sixpacks":
                        beers += amount * 6;
                        break;
                    case "cases":
                        beers += amount * 24;
                        break;
                }
                comand = Console.ReadLine();
            }
            beers = beers - (beers / 100);
            if (beers>=resBeers)
            {
                // o   “Cheers!Beer left: { amount of cases left} cases, { amount of sixpacks left} sixpacks and { amount of beers left} beers.”
                long beersLeft = beers - resBeers;
                long cases = beersLeft / 24;
                beersLeft = beersLeft % 24;
                long sixpacs = beersLeft / 6;
                beersLeft = beersLeft%6;
                Console.WriteLine("Cheers! Beer left: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacs, beersLeft);
            }
            else
            {
                // “Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.”
                long beersNeeded = resBeers - beers ;
                long cases = beersNeeded / 24;
                beersNeeded = beersNeeded % 24;
                long sixpacs = beersNeeded / 6;
                beersNeeded = beersNeeded % 6;
                Console.WriteLine("Not enough beer. Beer needed: {0} cases, {1} sixpacks and {2} beers.", cases, sixpacs, beersNeeded);
            }
        }
    }
}
