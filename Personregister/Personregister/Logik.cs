using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Logik
    {
        Personregister personRegistret = new Personregister(); //nytt personregister
        public void RunProgram(string input) //kör programmet, tar input från program.cs
        {
            switch (input)
            {
                case "1": //lägg till person
                    Console.WriteLine("För att lägga till en person skriv in lite information.\n");
                    Console.Write("Namn: ");
                    string name = Console.ReadLine();
                    Console.Write("Ålder: ");
                    string age = Console.ReadLine();
                    Console.Write("Stad: ");
                    string location = Console.ReadLine();
                    Console.WriteLine("\nPersonen har lagts till i registret.");
                    personRegistret.AddPerson(name, age, location);
                    break;
                case "2": //visa personlista med hjälp av namn
                    Console.WriteLine("Personlisa:\n");
                    foreach(Person person in personRegistret.personRegister)
                    {
                        Console.WriteLine($"{person.ShowName()}"); //skriver alla namn i listan för bättre användarvänlighet
                    }
                    Console.WriteLine("\nSkriv namnet på personen för att få mer information.\n");
                    string showPersonInput = Console.ReadLine();
                    foreach(Person person in personRegistret.personRegister)    //går igenom alla personer
                    {
                        if(showPersonInput == person.ShowName()) //är input lika med ett namn
                        {
                            person.ShowEverything(); //visar allt
                        } 
                    }
                    break;
                case "meny":
                    Console.WriteLine("\nSkriv 1 för att lägga till en person.\nSkriv 2 för att kolla på listan.\nSkriv meny för att få denna meny igen.\nSkriv 0 för att avsluta.");
                    break;
                case "0":
                    Environment.Exit(1); //exit 
                    break;
                default:
                    break;
            }
        }
    }
}
