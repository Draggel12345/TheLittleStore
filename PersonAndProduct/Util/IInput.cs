using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndProduct.Util
{
    interface IInput
    {
        //The methods to get user input in string-value and int-value.
        int GetInt();
        string GetString();
    }
}
