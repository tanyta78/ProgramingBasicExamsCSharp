using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phone_Processes
{
    class Program
    {
        static void Main(string[] args)
        {
            string battery = Console.ReadLine();
            int batterypersentage = 0;
            int check = 0;
            int programsleft = 0;
            int bateryused = 0;
            if (battery.Length==3)
            {
                batterypersentage = int.Parse(battery.Substring(0, 2));

            }
            else
            {
                if (battery.Length > 3)
                {
                    batterypersentage = int.Parse(battery.Substring(0, 3));
                }
                else
                {
                    batterypersentage = int.Parse(battery.Substring(0, 1));
                }
            }
            string command= Console.ReadLine();
            while (command.ToUpper()!="END")
            {
                if (check==1)
                {
                    programsleft += 1;
                    command = Console.ReadLine();
                    continue;
                }
                else
                {
                    string[] parameters = command.Split('_');
                    bateryused = int.Parse(parameters[1].Substring(0,2));
                    if (((batterypersentage-bateryused)<=0)&&(programsleft==0))
                     {
                        command = Console.ReadLine();
                        
                        continue;
                    }
                    else
                    {
                        if ((batterypersentage - bateryused) <= 15)
                        {
                        Console.WriteLine("Connect charger -> {0}%", batterypersentage - bateryused);
                            check = 1;
                            programsleft += 1;
                        }
                        else
                        {
                            batterypersentage = batterypersentage - bateryused;
                           
                        }
                    
                }
                command = Console.ReadLine();

                }
            }
            if (((batterypersentage - bateryused) <= 0) && (programsleft == 0))
            {
                Console.WriteLine("Phone Off");
                check = 3;
               
            }
            switch (check)
            {
                case 1:
                    Console.WriteLine("Programs left -> {0}", programsleft);
                    break;
                case 0:
                    Console.WriteLine("Successful complete -> {0}%", batterypersentage);
                    break;
            }
            
            

        }
    }
}
