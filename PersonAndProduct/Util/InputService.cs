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
                WriteLine("Input has to be an integer and cant be empty field.");
                Write("Try again: ");
            }
            return integer;
        }

        public string GetString()
        {
            //Checks so GetString() returns msg if the string contains digits or IsNullOrEmpty.
            string str = ReadLine();
            while (str.Any(char.IsDigit) || string.IsNullOrEmpty(str))
            {
                WriteLine("Input has to be letters and cant be empty field.");
                Write("Try again: ");
                str = ReadLine();
            }
            return str;
        }
    }
}
