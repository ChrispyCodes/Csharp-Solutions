using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Class
{
    class Employee<t> : Person,  IQuitTable
    {
        public int Employee_Id { get; set; }
        public List<t> Things { get; set; }

        public override void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " " + LastName);
        }

        public void Quit()
        {
            string Resignation = ("I resign for my position effective immediately " + DateTime.Now.ToString("MM/dd/yyyy") +
                "\r\n" + FirstName + " " + LastName + "\r\n");
            Console.WriteLine(Resignation);
            Console.ReadLine();
        }

        public void Quit(string FirstName, string LastName)
        {
            string Resignation = ("I resign for my position effective immediately " + DateTime.Now.ToString("MM/dd/yyyy") + 
                "\r\n" + FirstName + " " + LastName + "\r\n");
            Console.WriteLine(Resignation);
            Console.ReadLine();
        }

        public static bool operator == (Employee<t> employee1, Employee<t> employee2)
        {
            bool sameEmpId = employee1.Employee_Id == employee2.Employee_Id;
            return sameEmpId;
        }

        public static bool operator !=(Employee<t> employee1, Employee<t> employee2)
        {
            bool sameEmpId = employee1.Employee_Id != employee2.Employee_Id;
            return sameEmpId;
        }

        public bool Equals(Employee<t> employee1, Employee<t> employee2)
        {
            bool sameEmpId = employee1.Employee_Id == employee2.Employee_Id;
            return sameEmpId;
        }

        public override bool Equals(object o)
        {
            bool sameEmpId = Employee_Id != Employee_Id;
            return sameEmpId;
        }

        public override int GetHashCode()
        {
            return Employee_Id;
        }

        public void PrintThings()
        {
            foreach(t thing in Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
