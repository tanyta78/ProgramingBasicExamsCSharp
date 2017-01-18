using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalExam060316
{
    class Program
    {
        static void Main(string[] args)
        {
            double width = double.Parse(Console.ReadLine())*100;
            double height = double.Parse(Console.ReadLine())*100;
            double tableinrow = Math.Truncate((height - 100) / 70);
            double tableincolumn = Math.Truncate(width / 120);
            double tableinroom = tableincolumn * tableinrow - 3;
            Console.WriteLine(tableinroom);
        }
    }
}
