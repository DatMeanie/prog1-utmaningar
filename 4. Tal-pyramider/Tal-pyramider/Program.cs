using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tal_pyramider
{
    class Program
    {
        static void Main(string[] args)
        {
            int turns = 0;

            Console.WriteLine("Type in a number");
            long number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine(" ");
            for (int i = 0; i < number; i += 1)
            {
               for(int j = 0; j < turns; j += 1)
               {
                    Console.Write(number);
               }
                Console.WriteLine(number);
                turns++; 
            }
            Console.WriteLine("\n\nType anything to exit");
            Console.ReadLine();
        }
    }
}
