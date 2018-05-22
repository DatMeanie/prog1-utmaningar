using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class Logik
    {
        int location = 1; //vilken station är användaren på?
        int howManySubways = 3; //hur många stationer finns det?
        public void RunProgram() //kör programm
        {
            if(location == 1) //if satserna get korrekt respons beroende på location och number av subways
            {   //ett är start station
                Console.WriteLine($"You see a train coming. You can board it to go to subwaystation {location + 1}");
                Menu(); //får menyn
            } else if(location == howManySubways)
            {
                Console.WriteLine($"You see a train coming. You can board it to go to subwaystation {location - 1} ");
                Menu();
            } else
            {
                Console.WriteLine($"You see two trains coming. You can board one to go to subwaystation {location - 1} or {location + 1}");
                Menu();
            }
        }
        public void Menu()
        {
            bool validInputControl = false;
            Console.WriteLine("Input subwaystation number to go there. Type exit to exit.");
            while (validInputControl == false)
            { 
                string inputSubwayStationNumber = Console.ReadLine(); 
                if (inputSubwayStationNumber == (location - 1).ToString() && location > 1) //if satserna kollar vart man är och om inputen funkar
                {   //location ändras                              //om man är på station 1
                    location--;
                    validInputControl = true;
                }
                else if (inputSubwayStationNumber == (location + 1).ToString() && location < howManySubways)
                {                                   //säkrare sätt än TryParse   //om location är på sista stationen
                    location++;
                    validInputControl = true;
                } else if(inputSubwayStationNumber.ToLower() == "exit")
                {                            //ToLower gör att bokstavsstorlek på input inte har betydelse 
                    Environment.Exit(1);
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again");
                }
            }
        }
    }
}
