using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();
            Console.WriteLine("Enter a number: ");
            int userInput1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number if you want: ");
            string userInput2 = Console.ReadLine();

            if (userInput2 == "")
            {
                numbers.Add(userInput1);
                numbers.displayOutValue();
            }
            else
            {
                int userInpConvert = Convert.ToInt32(userInput2);
                numbers.Add(userInput1, userInpConvert);
                numbers.displayOutValue();
            }




        }
    }
}
