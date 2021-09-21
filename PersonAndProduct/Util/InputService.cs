using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace PersonAndProduct.Util
{
    //InputService implements IInput
    class InputService : IInput
    {
        //GetString() and GetInt() are methods for input, used for example in the CreatePerson method in PersonService.
        public int GetInt()
        {
            //Checks to see if input value is equal to an integer, if not returns msg.
            int integer;
            while (!int.TryParse(ReadLine(), out integer))
            {
                WriteLine("\nInput has to be an integer.");
            }
            return integer;
        }
        public string GetString()
        {
            return ReadLine();
        }
    }
}
