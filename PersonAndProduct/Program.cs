using PersonAndProduct.Data;
using PersonAndProduct.Entity;
using System;
using System.Collections.Generic;
using static System.Console;


namespace PersonAndProduct
{
    class Program
    {
        //Creates a new static object called service.
        static readonly PersonService service = new();
        static void Main(string[] args)
        {
            //Creating new Person objects and using the methods from service.
            //Trying out Discard, using underscore insteed of --> Person person = service.CreatePerson();. Visual Studio recommended it for some reason?
            //The code still runs and works.
            _ = service.CreatePerson();

            //Testing the delete method, that goes by id.
            Person toDelete = new(14, 69, "To", "Delete");
            service.Save(toDelete);
            service.DeletePerson(toDelete.Id);

            //Testing all the FindBy...() methods.
            TestMethods();

            //Prints out all the people 
            service.PrintAll();

            ReadKey();

            //Visual Studio recommended this check.
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }
        }

        static void TestMethods()
        {
            //Create new objects.
            Person a = new(2, 48, "Bob", "Testsson");
            Person b = new(3, 23, "Kim", "Testsson");
            Person c = new(4, 36, "Sara", "Testsson");

            //Add them to list.
            List<Person> toFind = new();
            toFind.Add(a);
            toFind.Add(b);
            toFind.Add(c);

            //Loop through them all and saves them.
            foreach(Person p in toFind)
            {
                service.Save(p);
            }

            //Using the diffrent methods to see if they find by first name, id and last name.
            if (toFind.Contains(service.FindByFirstName("Bob"))
                && toFind.Contains(service.FindById(3))
                && toFind.Contains(service.FindByLastName("Testsson")))
            {
                WriteLine("\nSuccess!");
            }
            else
            {
                WriteLine("\nFail!");
            }
        }
    }
}
