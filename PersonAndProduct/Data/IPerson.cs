using PersonAndProduct.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndProduct.Data
{
    interface IPerson
    {
        //The methods to creat, save and read all person objects.

        Person CreatePerson();
        Person FindById(int id);
        Person FindByFirstName(String firstName);
        Person FindByLastName(String lastName);
        void PrintAll();
        Person Save(Person person);
        void DeletePerson(int id);
    }
}
