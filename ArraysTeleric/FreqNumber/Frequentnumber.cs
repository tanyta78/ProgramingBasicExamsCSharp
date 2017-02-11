using System;

namespace FreqNumber
{
    /// <summary>
    /// Write a program that finds the most frequent number in an array of N elements.
    /// </summary>
    public class Frequentnumber
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];

            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);

            int currentCount = 1;
            int maxCount = 1;
            int number = 0;
            for (int i = 1; i < N; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    currentCount++;
                }
                else
                {
                    currentCount = 1;
                }
                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                    number = numbers[i];
                }
            }
            if (N == 1)
            {
                maxCount = 1;
                number = numbers[0];
            }
            Console.WriteLine("{0} ({1} times)", number, maxCount);
        }
    }
}