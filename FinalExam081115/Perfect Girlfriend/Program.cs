using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Girlfriend
{
    class Program
    {
        static void Main(string[] args)
        {
            //[{day of the week}\{telephone number}\{size of bra}\{girl name}] until you receive the command “Enough dates!” 

            string comand = Console.ReadLine();
            int sum = 0;
            int perfectgirls = 0;
            while (comand !="Enough dates!")
            {
                string[] substrings = comand.Split('\\');
                string day = substrings[0];
                string telnumber = substrings[1];
                string bra = substrings[2];
                string girlname = substrings[3];
                switch (day)
                {
                    case "Monday":
                        sum += 1;
                        break;
                    case "Tuesday":
                        sum += 2;
                        break;
                    case "Wednesday":
                        sum += 3;
                        break;
                    case "Thursday":
                        sum += 4;
                        break;
                    case "Friday":
                        sum += 5;
                        break;
                    case "Saturday":
                        sum += 6;
                        break;
                    case "Sunday":
                        sum += 7;
                        break;
                   
                }
               // Console.WriteLine(sum);
                for (int i = 0; i < telnumber.Length; i++)
                {
                    int digit = telnumber[i]-'0';
                    sum += digit;
                }
               // Console.WriteLine(sum);
                //for bra to do
                 int braSize = 0;
            char braSizeLetter = bra[bra.Length - 1];

            if (bra.Length == 3)
            {
                braSize = int.Parse(bra.Substring(0, 2));
            }
            else
            {
                braSize = int.Parse(bra.Substring(0, 3));
            }
                sum += braSize * braSizeLetter;
               
                // Console.WriteLine(sum);
                //for name
                char firstlettername = girlname[0];
                sum -=firstlettername*(girlname.Length);
                //Console.WriteLine(sum);
                //For every input line you receive you have to print “[name] is perfect for you.” or “Keep searching, [name] is not for you.” 
                //depending on the calculations, until you receive the command “Enough dates!”
                //On the last line you should print the number of girls that are perfect for Ivan.
                
                if (sum>=6000)
                {
                    Console.WriteLine("{0} is perfect for you.", girlname);
                    perfectgirls += 1;
                }
                else
                {
                    Console.WriteLine("Keep searching, {0} is not for you.", girlname);
                }

                comand = Console.ReadLine();
                sum = 0;
            }
            Console.WriteLine(perfectgirls);


        }
    }
}
