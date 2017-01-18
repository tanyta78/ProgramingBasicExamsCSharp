using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepairingTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double squareside = double.Parse(Console.ReadLine());
            double tileWidght = double.Parse(Console.ReadLine());
            double tileHeight = double.Parse(Console.ReadLine());
            double seatWight = double.Parse(Console.ReadLine());
            double seatHeight = double.Parse(Console.ReadLine());
            double areaWithTiles = (squareside * squareside) - (seatHeight * seatWight);
            double tilearea = tileHeight * tileWidght;
            double tilesnumber =areaWithTiles/tilearea;
            double time =tilesnumber*0.2;
            Console.WriteLine(tilesnumber);
            Console.WriteLine(time);
           


        }
    }
}
