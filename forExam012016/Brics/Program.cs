using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Brics
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var bricks = double.Parse(Console.ReadLine());
            var workers = double.Parse(Console.ReadLine());
            var troley = double.Parse(Console.ReadLine());
            double courses = Math.Ceiling(bricks / (troley * workers));
            Console.WriteLine(courses);


        }
    }
}
