namespace MaxKSum
{
    using System;
    /// <summary>
    ///  Write a program that reads two integer numbers N and K and an array of N elements from the console.Find the maximal sum of K elements in the array.
    /// </summary>
    
    public class MaxKSum
    {
       public static void Main(string[] args)
        {
            int arrLenght = int.Parse(Console.ReadLine());
            int maxSumArrLenght = int.Parse(Console.ReadLine());
            int[] numbers = new int[arrLenght];
            int sum = 0;

            for (int i = 0; i < arrLenght; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            for (int i = 0; i < maxSumArrLenght; i++)
            {
                sum += numbers[arrLenght - 1 - i];
            }

            Console.WriteLine(sum);
        }
    }
}