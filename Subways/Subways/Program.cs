using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class Program
    {
        static void Main(string[] args)
        {
            //program made by Albin Fyhr TE16

            //ny logik skapas
            Logik newLogik = new Logik();

            while(69 != 1) //infinte loop, programmet slutas genom en funktion i RunProgram
            {
                newLogik.RunProgram();
                Console.Clear();
            }
        }
    }
}
