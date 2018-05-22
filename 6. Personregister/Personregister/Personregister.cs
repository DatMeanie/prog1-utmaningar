using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Personregister
    {
        public List<Person> personRegister = new List<Person>(); //ny lista
        public void AddPerson(string name, string age, string location) //lägg till person
        {
            personRegister.Add(new Person(name, age, location));
        }
    }
}
