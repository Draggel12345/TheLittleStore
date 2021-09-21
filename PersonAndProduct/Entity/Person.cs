using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndProduct.Entity
{
    class Person
    {
        //Basic Class that has variables with getters and private setters. A public constructor that uses the setters. And for last, an overriden ToString() method that uses the getters.  
        public int Id { get; private set; }
        public int Age { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public Person(int id, int age, string firstName, string lastName) => (Id, Age, FirstName, LastName) = (id, age, firstName, lastName);

        //Overriden ToString() does so every time you WriteLine(Person object),
        //it will use the text you have written inside the overriden ToString() method so you dont have to rewrite it all the time.
        public override string ToString()
        {
            return $"Id: {Id}, Full name: {FirstName + " " + LastName}, Age: {Age} years.";
        }
    }
}
