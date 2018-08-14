using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to PackageExpress. Please follow the instructions below.");
            Console.WriteLine("What is your package's weight in pounds? ");
            double weight = Convert.ToDouble(Console.ReadLine());

            string comparisonOne = weight > 50.0 ? "Package too heavy to be shipped via Package Express. Have a good day!" : "Press ENTER to continue... ";
            Console.WriteLine(comparisonOne);
            Console.ReadLine();

            if (weight > 50.0)
            {
                return;
            }

            Console.WriteLine("What is the width of your package in inches? ");
            double width = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the height of your package in inches? ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is the length of your package in inches? ");
            double length = Convert.ToDouble(Console.ReadLine());

            double dimensions = width + height + length;
            string comparisonTwo = dimensions > 50.0 ? "Package too big to be shipped via Package Express" : "Press ENTER for your quote.";
            Console.WriteLine(comparisonTwo);
            Console.ReadLine();

            if (dimensions > 50.0)
            {
                return;
            }

            double total = (dimensions * weight) / 100.0;
            Console.WriteLine("$" + total);
            Console.ReadLine();
        }
    }
}
