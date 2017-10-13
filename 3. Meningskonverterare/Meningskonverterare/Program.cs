using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meningskonverterare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program converts your sentence to uppercase letters or lowercase letters");
            Console.WriteLine("Type 1 for uppercase");
            Console.WriteLine("Type 2 for lowercase");
            Console.Write("Your Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine()); //WHAT WILL IT BE ???
            if(choice == 1) //TO UPPER MAYBE?
            {
                Console.Write("Your Sentence: ");
                string sentence = Console.ReadLine();
                Console.WriteLine("Converted: " + sentence.ToUpper());
            }
            if (choice == 2) //only plebs take the low route
            {
                Console.Write("Your Sentence: ");
                string sentence = Console.ReadLine();
                Console.WriteLine("Converted: " + sentence.ToLower());
            }
            else {
                Console.WriteLine("Wow man, that was not a choice. now you have to restart the program!");
            }
            Console.ReadLine();
        }
    }
}