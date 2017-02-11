using System;
namespace BinarySearch
{
    public class BinarySearch
    {
        /// <summary>
        /// /Write a program that finds the index of given element X in a sorted array of N integers by using the Binary search algorithm.
        /// </summary>
        static void Main()
        {
            int countOfNumbers = int.Parse(Console.ReadLine());

            int[] numbers = new int[countOfNumbers];
            for (int i = 0; i < countOfNumbers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int searchedElement = int.Parse(Console.ReadLine());

            int middleElement = -1;
            Array.Sort(numbers);

            int Left = 0;
            int Right = countOfNumbers - 1;
            while (true)
            {

                middleElement = (Left + Right) / 2;

                if (numbers[middleElement] < searchedElement)
                {
                    Left = middleElement + 1;
                    continue;
                }
                else if (numbers[middleElement] > searchedElement)
                {
                    Right = middleElement - 1;
                    continue;
                }
                else if (numbers[middleElement] == searchedElement)
                {
                    break;
                }
            }
            Console.WriteLine("Searched number is on index " + middleElement);
        }
    }
}
