using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterProducer
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.The number of albums sold in Europe
            //2.The price of an album in euro
            //3.The number of albums sold in North America
            //4.The price of an album in dollars
            //5.The number of albums sold in South America
            //6.Price of an album in pesos
            //7.The number of concerts during a tour
            //8.Profit from a single concert in euro
            //•	1 euro is 1.94lv.
            //•	1 dollar is 1.72lv.
            //•	332.74 pesos are 1lv.
            decimal EuropeAlbums = decimal.Parse(Console.ReadLine());
            decimal EuAlbumsprice = decimal.Parse(Console.ReadLine());
            decimal NAAlbums = decimal.Parse(Console.ReadLine());
            decimal NAAlbumsprice = decimal.Parse(Console.ReadLine());
            decimal SAAlbums = decimal.Parse(Console.ReadLine());
            decimal SAAlbumsprice = decimal.Parse(Console.ReadLine());
            decimal concertsnumber = decimal.Parse(Console.ReadLine());
            decimal concertprofit = decimal.Parse(Console.ReadLine());
            decimal ProfitfromConcert = concertprofit * concertsnumber*1.94m;
            if (ProfitfromConcert>100000)
            {
                ProfitfromConcert =(decimal) ProfitfromConcert * 85 / 100;
            }
            decimal ProfitfromAlbums = (EuAlbumsprice * EuropeAlbums * 1.94m + NAAlbums * NAAlbumsprice * 1.72m + SAAlbums * SAAlbumsprice / 332.74m) * 65 * 80 / 10000;
            if (ProfitfromAlbums>ProfitfromConcert)
            {
                Console.WriteLine("Let's record some songs! They'll bring us {0:f2}lv.",ProfitfromAlbums);
            }
            else
            {
                Console.WriteLine("On the road again! We'll see the world and earn {0:f2}lv.", ProfitfromConcert);
            }
        }
    }
}
