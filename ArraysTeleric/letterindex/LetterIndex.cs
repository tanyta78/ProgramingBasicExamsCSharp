using System;

namespace letterindex
{
    /// <summary>
    /// Write a program that creates an array containing all letters from the alphabet (a-z). Read a word from the console and print the index of each of its letters in the array.
    /// </summary>
    public class LetterIndex
    {
        public static void Main(string[] args)
        {
            char[] letters = new char[26];
            int counter = 0;
            for (char i = 'a'; i <= 'z'; i++)
            {
                letters[counter] = i;
                counter++;
            }
            
            string word = Console.ReadLine().ToLower();
            foreach (var item in word)
            {
                for (int i = 0; i < 26; i++)
                {
                    if (item == letters[i])
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}