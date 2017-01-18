using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Takeplanedown
{
    class Program
    {
        static void Main(string[] args)
        {
            int centerX = int.Parse(Console.ReadLine());
            int centerY = int.Parse(Console.ReadLine());
            int radius = int.Parse(Console.ReadLine());
            int planes = int.Parse(Console.ReadLine());
            for (int i = 0; i < planes; i++)
            {
                int planeX= int.Parse(Console.ReadLine());
                int planeY = int.Parse(Console.ReadLine());
                int planeXdist = planeX - centerX;
                int planeYdist = planeY - centerY;
                double planesR = Math.Sqrt(planeXdist * planeXdist + planeYdist * planeYdist);
                if (planesR<=radius)
                {
                    Console.WriteLine("You destroyed a plane at [{0},{1}]", planeX, planeY);
                }
            }
        }
    }
}
