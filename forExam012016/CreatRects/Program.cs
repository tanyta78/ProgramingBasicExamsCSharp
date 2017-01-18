using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatRects
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int minArea = int.Parse(Console.ReadLine());
            int check = 0;
            for (int left = -n; left <= n; left++)
            {
                for (int top = -n; top <= n; top++)
                {
                    for (int right = left + 1; right <= n; right++)
                    {

                        for (int bottom = top + 1; bottom <= n; bottom++)
                        {
                            int width = right - left;
                            int height = bottom - top;
                            int area = width * height;
                            if (area >= minArea)
                            {
                                Console.WriteLine("({0}, {1}) ({2}, {3}) -> {4}", left, top, right, bottom,area);
                                check += 1;
                            }
                        }
                    }
                }
            }

            if (check == 0)
            {
                Console.WriteLine("No");
            }
        }
    }
}
