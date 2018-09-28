using System;
using System.Collections.Generic;
using System.Threading;

namespace ListAndArrayIteration
{
    class Program
    {
        static void Main()
        {
            ////Creation of one-dimensional array, add users string to the value of each element 
            ////within the array and print the value of each element to the console
            //string[] pets = { "The dog said", "The cat said", "The bird said", "The horse said" };
            //Console.WriteLine("If your pet could speak, what would it say?");
            //string petsWords = Console.ReadLine().ToLower();

            //for (int i = 0; i < pets.Length; i++)
            //{
            //    pets[i] = pets[i] + " " + petsWords;
            //}
            //for (int i = 0; i < pets.Length; i++)
            //{
            //    Console.WriteLine(pets[i]);
            //}

            //Console.ReadLine();

            ////// infinate loop
            ////List<string> colors = new List<string>() { "blue", "green", "yellow", "orange", "red" };
            ////int j = 0;
            ////string color;
            ////Console.WriteLine("The colors in my list are...... \r\n");
            ////do
            ////{
            ////    color = colors[j];
            ////    Console.WriteLine(color);
            ////}
            ////while (color != "red");

            ////fix loop
            //List<string> colors = new List<string>() { "blue", "green", "yellow", "orange", "red" };
            //int j = 0;
            //string color;
            //Console.WriteLine("The colors in my list are...... \r\n");
            //do
            //{
            //    color = colors[j];
            //    Console.WriteLine(color);
            //    j++;
            //}
            //while (color != "red");
            //Console.ReadLine();

            //// Loop comparison with < operator
            //List<int> ages = new List<int>() { 13, 22, 16, 32, 54 };
            //List<int> minors = new List<int>();
            //for (int i = 0; i < ages.Count; i++)
            //{
            //    if (ages[i] < 21)
            //    {
            //        minors.Add(ages[i]);
            //    }
            //}
            //Console.WriteLine("How man minors are in this group of people..... \r\n");
            //Thread.Sleep(1000);
            //Console.WriteLine("There are " + minors.Count + " minors in this group");
            //Console.ReadLine();


            //// Loop comparison with <= operator
            //int savings = 0;
            //int earnedMoney;
            //while (savings <= 500)
            //{
            //    Console.WriteLine(string.Format("{0:C}", savings) + " is not enough to invest in stocks");
            //    earnedMoney = new Random().Next(50, 100);
            //    savings = savings + earnedMoney;
            //}
            //Console.WriteLine("You have saved enought to invest your money!" +
            //    " how would you like to invest your " + string.Format( "{0:C}",  savings));

            //Console.ReadLine();

            //// Loop to search for text within a list of strings
            //List<string> favColors = new List<string>() { "blue", "green", "purple", "red", "yellow", "orange" };
            //string favColor;
            //string message = null;
            //Console.WriteLine("As part of a recent study both men and women were asked 'Whats your favorite color?'  \r\n" +
            //    "Does your favorite color fall within the top 6? \r\n" +
            //    "What is your favorite color");
            //favColor = Console.ReadLine().ToLower();
            //for(int i = 0; i < favColors.Count; i++)
            //{
            //    if (favColors[i].Contains(favColor))
            //    {
            //        message =(favColor + " is your favorite color, that is number " + (i + 1).ToString() + " in the top 6!");
            //        break;
            //    };
            //}
            //message = String.IsNullOrEmpty(favColor)? "What!?!  you don't have a favorite color? ": String.IsNullOrEmpty(message) ? "Your favorite color is not in the top 6" : message;
            //Console.WriteLine(message);
            //Console.ReadLine();

            //// List of strings with dup text in elements
            //List<string> jNames = new List<string>() { "Jack", "Jill", "Jennifer", "Jack", "Jeff", "James", "Jill", "Jane", "James" };
            //Console.WriteLine("Pick a name that starts with 'J' and I will tell you how many stutdents in our class have that name");
            //string selectedName = Console.ReadLine();
            //selectedName = String.IsNullOrEmpty(selectedName)? selectedName: selectedName.Substring(0, 1).ToUpper() + selectedName.Substring(1).ToLower();
            //int nameCount = 0;
            //foreach (string name in jNames)
            //{
            //    if(name == selectedName)
            //    {
            //        nameCount = nameCount + 1;
            //    }
            //}
            //message = nameCount == 0 ? "There is nobody in our class with the name " + selectedName :
            //    nameCount == 1 ? "There is " + nameCount.ToString() + " stuednt named " + selectedName + " in our class":  "There are " + nameCount.ToString() +" stuednts named " + selectedName + " in our class";
            //Console.WriteLine(message);
            //Console.ReadLine();

            //List of strings and for loop to indicate if eacg string has already appeared in the list
            List<string> mNames = new List<string>() { "Mary", "Mike", "Mindy", "Mandy", "Mark", "Mary", "Mark" };
            string dupNameMessage = null;
            for (int i =  0; i < mNames.Count; i++)
            {
                for(int a= 0; a < i; a++)
                {
                    dupNameMessage = null;
                    if(mNames[i] == mNames[a])
                    {
                        dupNameMessage = (i.ToString() + ". " + mNames[i] + " has already appeared in this list");
                        break;
                    }
                }
                dupNameMessage = String.IsNullOrEmpty(dupNameMessage) ? i.ToString() + ". " + mNames[i] + " has not already appeared in this list" : dupNameMessage;
                Console.WriteLine(dupNameMessage);
            }
            Console.ReadLine();
        }
    }
}
