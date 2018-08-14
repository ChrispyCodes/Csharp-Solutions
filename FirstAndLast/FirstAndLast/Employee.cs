using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLast
{
    public class Employee 
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Id { get; set; }
        public int Id2 { get; set; }


        //public Employee(string first, string last, int _id)
        //{
        //    this.FirstName = first;
        //    this.LastName = last;
        //    _id = Id;
        //}
        public void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.WriteLine("id : {0}", Id);

            Console.ReadLine();
        }

        public void Quit()
        {
            Console.WriteLine("Employee # " + Id + " Has Just Quit!");
         
        }
        //public static bool operator ==(Employee<T> Id, Employee<T> Id2)
        //{
        //    return Equals(Id, Id2);
        //}
        //public static bool operator !=(Employee<T> Id, Employee<T> Id2)
        //{
        //    return !Equals(Id, Id2);
        //}

    }
}
