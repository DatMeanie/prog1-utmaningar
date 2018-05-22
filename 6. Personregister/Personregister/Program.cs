using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Program
    {
        static void Main(string[] args)
        {
            Logik newLogik = new Logik(); //ny logik
            Console.WriteLine("Välkommen till Personregistret.\nSkriv 1 för att lägga till en person.\nSkriv 2 för att kolla på listan.\nSkriv meny för att få denna meny igen.\nSkriv 0 för att avsluta.");
            while (69 != 1) //kör tills man skriver 0 i logikfunctionen
            {
                string input = Console.ReadLine();
                newLogik.RunProgram(input.ToLower()); //tolower gör att boksstavsstorlek inte spelar roll
            }
        }
    }
}
