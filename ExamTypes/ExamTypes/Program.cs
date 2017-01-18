using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            // ЛИЦЕ И ПЕРИМЕТЪР НА ПРАВОЪГЪЛНИК
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double width = Math.Max(x1, x2) - Math.Min(x1, x2);
            double height = Math.Max(y1, y2) - Math.Min(y1, y2);
            Console.WriteLine("Area = {0}", width * height);
            Console.WriteLine("Perimeter = {0}", 2 * (width + height));
//ПРОВЕРЯВА ДАЛИ ТОЧКАТА Е В ИЛИ ИЗВЪН ПРАВОЪГЪЛНИКА
            var x = 8, y = -1;
            var x1 = 2, y1 = -3;
            var x2 = 12, y2 = 3;
            if (x >= x1 && x <= x2 && y >= y1 && y <= y2)
                Console.WriteLine("Inside");
            else
                Console.WriteLine("Outside");
//ПРОВЕРЯВА ДАЛИ ТОЧКАТА Е ВЪРХУ НЯКОЯ ОТ СТРАНИТЕ
            if (((x == x1 || x == x2) &&
     (y >= y1) && (y <= y2)) ||
    ((y == y1 || y == y2) &&
     (x >= x1) && (x <= x2)))
            {
                Console.WriteLine("Border");
            }
            //ИЛИ ТАКА
            var onLeftSide = (x == x1) && (y >= y1) && (y <= y2);
            var onRightSide = (x == x2) && (y >= y1) && (y <= y2);
            var onUpSide = (y == y1) && (x >= x1) && (x <= x2);
            var onDownSide = (y == y2) && (x >= x1) && (x <= x2);
            if (onLeftSide || onRightSide || onUpSide || onDownSide)
            {
                Console.WriteLine("Border");
            }


        }
    }
}
