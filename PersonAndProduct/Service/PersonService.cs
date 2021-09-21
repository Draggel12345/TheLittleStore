using PersonAndProduct.Entity;
using PersonAndProduct.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace PersonAndProduct.Data
{
    //PersonService extending InputService and implementing IPerson
    class PersonService : InputService, IPerson
    {
        //A counter that increase in value every time a person object is created. Insteed of setting the id value yourself for every object.
        private static int IdCounter = 0;

        //List where all the Person object will be saved.
        private List<Person> people = new List<Person>();

        //The save method adds the person object in the list people.
        public Person Save(Person person)
        {
            //If the same person is in the list, dont add that person.
            if (!people.Contains(person))
            {
                people.Add(person);
            }
            return person;
        }
        //When the program is running, asks for user input and then saves the new person object in the people list.
        public Person CreatePerson()
        {
            Write("Enter in your first name: ");
            string firstName = GetString();
            Write("Enter in your last name: ");
            string lastName = GetString();
            Write("Enter in your age: ");
            int age = GetInt();
            int id = ++IdCounter;
            WriteLine("");

            return Save(new Person(id, age, firstName, lastName));
        }

        //Prints all the person objects in the list. Count is for a lovely number before every object.
        public void PrintAll()
        {
            int count = 0;
            foreach(Person p in people)
            {
                WriteLine($"{++count}. {p}");
            }
        }
    }
}
