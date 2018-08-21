using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>() { FirstName = "Sample", LastName = "Student", Employee_Id = 1 };
            Employee<int> employee2 = new Employee<int>() { FirstName = "Star", LastName = "Employee", Employee_Id = 2};
            employee1.SayName();
            employee1.Things = new List<string>() { "This", "is", "a", "list", "of", "things" };
            employee1.PrintThings();

            employee2.SayName();
            employee2.Things = new List<int>() { 5, 4, 3, 2, 1 };
            employee2.PrintThings();
            Console.ReadLine();
        }
    }
}
