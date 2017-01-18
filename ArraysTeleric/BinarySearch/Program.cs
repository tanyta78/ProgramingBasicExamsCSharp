using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            // array with n elements
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
            }
            int X = int.Parse(Console.ReadLine());
            int index = -1;
            int currentindex = -1;
            Array.Sort(numbers);
            //find and check the middle element

            //            Set L to 0 and R to n − 1.
            //If L > R, the search terminates as unsuccessful.
            //Set m(the position of the middle element) to the floor(the largest previous integer) of(L + R) / 2.
            //If Am < T, set L to m +1 and go to step 2.
            //If Am > T, set R to m – 1 and go to step 2.
            //Now Am = T, the search is done; return m
            int Left = 0;
            int Right = N - 1;
            while (true)
            {

                currentindex = (Left + Right) / 2;
                
                    if (numbers[currentindex] < X)
                    {
                        Right = currentindex - 1;
                        continue;
                    }
                    else
                    {
                        Left = currentindex + 1;
                        continue;
                    }
                    if (min == max || min == max - 1) //output
                    {
                        if (arr[min] == needed)
                        {
                            Console.WriteLine(min);
                            return;
                        }
                        else if (arr[max] == needed)
                        {
                            Console.WriteLine(max);
                            return;
                        }
                        else
                        {
                            Console.WriteLine(-1);
                            return;
                        }
                    }
          
            
        