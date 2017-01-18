﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSequence
{
    class MaxSequence
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int maxSequance = 1;
            int currentSequance = 1;
            numbers[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                numbers[i]= int.Parse(Console.ReadLine());
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequance++;
                }
                else
                {
                    currentSequance = 1;
                }
                if (currentSequance>maxSequance)
                    {
                        maxSequance = currentSequance;
                    }
                    
                }
            Console.WriteLine(maxSequance);
            }

        }
    }

