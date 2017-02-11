namespace SelectionSort
{
    using System;

    /// <summary>
    /// Sorting an array means to arrange its elements in increasing order. Write a program to sort an array. Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.
    /// </summary>
    public class SelSort
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int minnumber = numbers[0];
            int index = 0;
            for (int i = 0; i < N; i++)
            {
                minnumber = numbers[i];
                for (int j = i; j < N; j++)
                {
                    if (numbers[j] < minnumber)
                    {

                        minnumber = numbers[j];
                        index = j;

                    }
                }
                if (minnumber != numbers[i])
                {
                    int oldnumber = numbers[i];
                    numbers[i] = minnumber;
                    numbers[index] = oldnumber;
                }

            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}