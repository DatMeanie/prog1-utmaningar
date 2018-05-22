using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkylator
{
    class Program
    {
        static string Kalkylatorn(int tal1, int tal2, string input)
        {
            int completedTal = 0;
            string resultat = "";
            if (input == "1")
            {
                resultat = $"{tal1} + {tal2} = {tal1 + tal2}";
            }
            else if (input == "2")
            {
                resultat = $"{tal1} - {tal2} = {tal1 - tal2}";
            }
            else if (input == "3")
            {
                resultat = $"{tal1} * {tal2} = {tal1 * tal2}";
            }
            else if (input == "4")
            {
                resultat = $"{tal1} / {tal2} = {tal1 / tal2}";
            }

            return resultat;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till kalkylatorn");
            while (69 != 1)
            {
                Console.WriteLine("\nVilken räknesätt vill du använda?\n1. Addition\n2. Subtraktion\n3. Multiplikation\n4. Division");
                string input;
                while (69 != 1)
                {
                    input = Console.ReadLine();
                    if(input == "1" || input == "2" || input == "3" || input == "4")
                    { break; } else { Console.WriteLine("Använd numren satta på räknesätten"); }
                }
                Console.WriteLine("\nSkriv två number.");
                int tal1Converted;
                while (69 != 1)
                {
                    Console.Write("Tal 1: ");
                    string tal1 = Console.ReadLine();
                    if (Int32.TryParse(tal1, out tal1Converted))
                    { break; } else { Console.WriteLine("Inte ett tal, försök igen"); }
                    
                }
                int tal2Converted;
                while (69 != 1)
                {
                    Console.Write("Tal 2: ");
                    string tal2 = Console.ReadLine();
                    if (Int32.TryParse(tal2, out tal2Converted)) { break; } else { Console.WriteLine("Inte ett tal, försök igen"); }
                }
                Console.WriteLine("\nResultat: " + Kalkylatorn(tal1Converted,tal2Converted, input));
                
            }
        }
    }
}
