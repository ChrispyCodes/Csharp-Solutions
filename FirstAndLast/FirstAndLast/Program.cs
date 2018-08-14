using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndLast
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Employee> empList = new List<Employee>();

                empList.Add(new Employee() {FirstName = "Bob", LastName = "John", Id = 1 });
                empList.Add(new Employee() {FirstName = "Roy", LastName = "Wills", Id = 2 });
                empList.Add(new Employee() {FirstName = "Joe", LastName = "Bankwell", Id =3 });
                empList.Add(new Employee() {FirstName = "Ron", LastName = "Weasley", Id = 4 });
                empList.Add(new Employee() {FirstName = "Mason", LastName = "Smith", Id = 5});
                empList.Add(new Employee() {FirstName = "Byron", LastName = "Mag", Id = 6});
                empList.Add(new Employee() {FirstName = "Armando", LastName = "Meraz", Id = 7});
                empList.Add(new Employee() {FirstName = "Ashley", LastName = "Wall", Id = 8});
                empList.Add(new Employee() {FirstName = "Joe", LastName = "Newall", Id = 9});
                empList.Add(new Employee() {FirstName = "Chris", LastName = "Rax", Id = 10});
                empList.Add(new Employee() {FirstName = "Bobby", LastName = "Johnell", Id= 11});

            //Console.WriteLine("Employee's with the same name:");
            //List<Employee> sameName = empList.Where(x => x.FirstName == "Joe").ToList();

            //foreach (Employee name in sameName)
            //{
            //    Console.WriteLine(name.FirstName + " " + name.LastName + " " + name.Id);
            //}

            //Console.WriteLine("\nEmployee's with ID greater than 5: ");
            //List<Employee> greaterThanFive = empList.Where<Employee>(x => x.Id > 5).ToList();

            //foreach (Employee name1 in greaterThanFive)
            //{
            //    Console.WriteLine(name1.FirstName + " " + name1.LastName + " " + name1.Id); 
            //}

            //KEEPING THE ORIGINAL FOREACH LOOP TO FIND THE SAME NAME
            List<Employee> Joes = new List<Employee>();
            foreach (Employee name in empList)
            {
                if (name.FirstName == "Joe")
                {
                    Joes.Add(name);
                    Console.WriteLine(name.FirstName + " " + name.LastName);
                }
            }

            Console.ReadLine();
            
            
        }
    }

    
 }

