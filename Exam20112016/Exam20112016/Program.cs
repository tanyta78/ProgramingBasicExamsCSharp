using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam20112016
{
    class Program
    {
        static void Main(string[] args)
        {

            //            •	Паламуд – 60 % по - скъп от скумрията
            //•	Сафрид – 80 % по - скъп от цацата
            //•	Миди – 7.50 лв.за килограм
            //Вход
            //От конзолата се четат 5 числа:
            //•	Първи ред – цена на скумрията на килограм.Реално число в интервала[0.00…40.00]
            //•	Втори ред – цена на цацата на килограм.Реално число в интервала[0.00…30.00]
            //•	Трети ред – килограма паламуд. Реално число в интервала[0.00…50.00]
            //•	Четвърти ред – килограма сафрид. Реално число в интервала[0.00… 70.00]
            //•	Пети ред – килограма миди. Цяло число в интервала[0... 100]
            // паламуд, сафрид и миди.

            double skumriaprice = double.Parse(Console.ReadLine());
            double cacaprice = double.Parse(Console.ReadLine());
            double palamudkg = double.Parse(Console.ReadLine());
            double safridkg = double.Parse(Console.ReadLine());
            double midikg = double.Parse(Console.ReadLine());
            double safridprice = cacaprice * 1.8;
            double palamudprice = skumriaprice * 1.6;
            double sum = palamudkg * palamudprice + safridkg * safridprice + midikg * 7.5;
            Console.WriteLine("{0:f2}",sum);



        }
    }
}
