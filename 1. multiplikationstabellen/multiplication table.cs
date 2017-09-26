using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplikationstabell
{
    class Program
    {
        static void Main(string[] args)
        {
            //made by albin Fyhr
            //multiplication table thingie
            long numValue = -1;
            Console.WriteLine("Type in a number. It will show it's multiplication table.");
            while (numValue == -1) { //will try to convert string to int loop
                try
                {
                    string userInput = Console.ReadLine();
                    numValue = Convert.ToInt64(userInput); //if it didn't work it goes to the exceptions
                    break;
                }
                catch(FormatException) //not a number input
                {
                    Console.WriteLine("Invalid Input. Not a number");
                }
                catch (OverflowException) //too big of a number input
                {
                    Console.WriteLine("Invalid Input. Too big number");
                }
            }
            Console.WriteLine("\n-------------------------\n");
            for (int i = 1; i < 11; i++) //multiplies the input number ten times
            { 
                Console.WriteLine(numValue + " x " + i + " = " + numValue * i);
            }
            Console.WriteLine("\n-------------------------");
            Console.WriteLine("That was it! Press any key to exit");
            Console.ReadLine();
        }
    }
}
