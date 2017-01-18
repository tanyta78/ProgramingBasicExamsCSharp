using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnswerEncoding
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfQuestions = int.Parse(Console.ReadLine());
            string realanswer;
            string realAnsStr="";
            uint answerA = 0;
            uint answerB = 0;
            uint answerC = 0;
            uint answerD = 0;
            for (int i = 0; i < numberOfQuestions; i++)
            {
                uint answer = uint.Parse(Console.ReadLine());
                uint reminder = answer % 4;
                switch (reminder)
                {
                    case 0:
                        realanswer = "a";
                        realAnsStr += "a ";
                        answerA += 1;
                        break;
                    case 1:
                        realanswer = "b";
                        realAnsStr += "b ";
                        answerB += 1;
                        break;
                    case 2:
                        realanswer = "c";
                        realAnsStr += "c ";
                        answerC += 1;
                        break;
                    case 3:
                        realanswer = "d";
                        realAnsStr += "d ";
                        answerD += 1;
                        break;
                    default:
                        break;
                }
            }
                Console.WriteLine();
            Console.WriteLine(realAnsStr);
                Console.WriteLine("Answer A: {0}", answerA);
                Console.WriteLine("Answer B: {0}", answerB);
                Console.WriteLine("Answer C: {0}", answerC);
                Console.WriteLine("Answer D: {0}", answerD);
            }
        }
    }

