using System;
namespace ArraysTeleric
{
    /// <summary>
    /// Write a program that allocates array of N integers, initializes each element by its index multiplied by 5 and the prints the obtained array on the console.
    /// </summary>
    public class ArraysTeleric
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] numbers = new int[N];
            for (int i = 0; i < N; i++)
            {
                numbers[i] = i * 5;
                Console.WriteLine(numbers[i]);
            }
        }
    }
}