namespace MaxSequence
{
    using System;
    /// <summary>
    /// Write a program that finds the length of the maximal increasing sequence in an array of N integers.
    /// </summary>

    public class MaxSequence
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            int maxSequance = 1;
            int currentSequance = 1;
            numbers[0] = int.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                if (numbers[i] == numbers[i - 1])
                {
                    currentSequance++;
                }
                else
                {
                    currentSequance = 1;
                }
                if (currentSequance > maxSequance)
                {
                    maxSequance = currentSequance;
                }

            }
            Console.WriteLine(maxSequance);
        }
    }
}