using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassPractice
{
    public class Numbers
    {
        public int OutValue;
        public int? num2 = null;

        public void displayOutValue()
        {
            Console.WriteLine("Value: " + OutValue);
            Console.ReadLine();

        }
        public void Add(int num1, int num2 = 0)
        {

            OutValue = num1 + num2;

        }

        //public static void Walk(int num, out int num1)
        //{
        //    num1 = num / 2;
        //}
        //public static void Walk(string num)
        //{

        //}

    }
}
