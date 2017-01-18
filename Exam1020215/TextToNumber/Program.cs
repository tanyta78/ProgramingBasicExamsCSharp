using System;


namespace TextToNumber
{
    class Program
    {
        static void Main()
        {
            int M = int.Parse(Console.ReadLine());
            string text = Console.ReadLine();
            int RESULT = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char ch = text[i];
                if (ch=='@')
                {
                    break;
                }
                else if ('0'<=ch && ch<='9')
                {
                    RESULT = (ch-48)*RESULT;
                }
                else if ('a' <= ch && ch <= 'z')
                {
                    RESULT += ch-97;
                }
                else if ('A' <= ch && ch <= 'Z') 
                {
                    RESULT += ch-65;
                }
                else
                {
                    RESULT = RESULT % M;
                }

                ;
            }

            Console.WriteLine(RESULT);
        }
    }
}
    

