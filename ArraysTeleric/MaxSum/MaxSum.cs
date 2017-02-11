namespace MaxSum
{
    using System;

    /// <summary>
    /// Write a program that finds the maximal sum of consecutive elements in a given array of N numbers.
    /// </summary>
   public class MaxSum
    {
       public static void Main()
        {
            int N = int.Parse(Console.ReadLine());

            int[] numbers = new int[N];
            numbers[0] = int.Parse(Console.ReadLine());
            int maxSum = numbers[0];
            int recentSum = numbers[0];
            int start = 0;
            int end = 0;
            int tempstart = 0;

            for (int i = 1; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                recentSum += numbers[i];
                if (recentSum < numbers[i])
                {
                    recentSum = numbers[i];
                    tempstart = i;
                }
                if (recentSum > maxSum)
                {
                    maxSum = recentSum;
                    end = i;
                    start = tempstart;
                }

            }

            Console.WriteLine(maxSum);
        }
    }
}