using System;
namespace CompareArrays
{
    /// <summary>
    /// Write a program that reads two integer arrays of size N from the console and compares them element by element.
    /// </summary>
    public class CompareArrays
    {
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int[] Array1 = new int[N];
            int[] Array2 = new int[N];
            bool IsEqual = true;

            for (int i = 0; i < N; i++)
            {
                Array1[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < N; i++)
            {
                Array2[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < N; i++)
            {
                if (Array1[i] != Array2[i])
                {
                    IsEqual = false;
                    break;
                }
            }
            if (IsEqual)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not equal");
            }
        }
    }
}