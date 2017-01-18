using System;


namespace OnTimeForExam
{
    class Program
    {
        static void Main(string[] args)
        {
            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());
            int stHour = int.Parse(Console.ReadLine());
            int stMin = int.Parse(Console.ReadLine());
            int exinmin = examHour * 60 + examMin;
            int stinmin = stHour * 60 + stMin;
            if (exinmin < stinmin)
            {
                Console.WriteLine("Late");
                if ((stinmin - exinmin) >= 60)
                {
                    Console.WriteLine("{0}:{1:00} hours after the start", (stinmin - exinmin) / 60, (stinmin - exinmin) % 60);
                }
                else
                {
                    Console.WriteLine("{0} minutes after the start", (stinmin - exinmin) % 60);
                }
            }
            else
            {
                if (exinmin != stinmin)
                {

                    if ((exinmin - stinmin) >= 60)
                    {
                        Console.WriteLine("Early");
                        Console.WriteLine("{0}:{1:00} hours before the start", (exinmin - stinmin) / 60, (exinmin - stinmin) % 60);
                    }
                    else
                    {
                        if ((exinmin - stinmin) > 30)
                        {
                            Console.WriteLine("Early");
                            Console.WriteLine("{0} minutes before the start", (exinmin - stinmin) % 60);
                        }
                        else
                        {
                            Console.WriteLine("On time");
                            Console.WriteLine("{0} minutes before the start", (exinmin - stinmin) % 60);
                        }
                    }
                }

                else
                {
                    Console.WriteLine("On time");
                }
            }
        }
    }
}
