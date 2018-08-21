using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    interface IQuitTable
    {
        void Quit();
        void Quit(string FirstName, string LastName);
    }
}
