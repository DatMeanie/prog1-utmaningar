using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Person
    {
        string name;
        string age;
        string location;
        public Person(string name, string age, string location) //konstruktor
        {
            this.name = name;
            this.age = age;
            this.location = location;
        }
        public void ShowEverything() //visa allt
        {
            Console.WriteLine($"Namn: {name}\nÅlder: {age}\nStad: {location}");
        }
        public string ShowName()
        {   //return name
            return name;
        }
    }
}
