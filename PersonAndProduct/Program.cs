using PersonAndProduct.Data;
using PersonAndProduct.Entity;
using System;
using System.Collections.Generic;
using static System.Console;


namespace PersonAndProduct
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creates a new object called service.
            PersonService service = new();

            //Creating new Person objects and using the methods from service.
            Person a = service.CreatePerson();
            Person b = service.CreatePerson();

            service.PrintAll();

            ReadKey();
        }
    }
}
