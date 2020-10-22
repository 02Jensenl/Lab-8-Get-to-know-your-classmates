using System;

namespace Lab8GettoKnowYourClassmates
{
    class Program
    {
        static void Main(string[] args)
        {
            bool playAgain = true;
            while (playAgain)
            {

                string[] Student = { "Aaron", "Chelsea", "Edward", "Shelby", "Carl", "Mary", "Paul", "Heather", "Darren", "Melody" };
                string[] Hometown = { "Milford", "Keego Harbor", "Westland", "Bay City", "Blissfield", "Algonac", "Standish", "Lansing", "Escanaba", "Marquette" };
                string[] Food = { "Chili", "Lobster", "Curry", "Sushi", "Tacos", "Chicken parmesan", "Spaghetti", "Waffles", "Salmon", "Falafel" };
                string[] Color = { "Red", "Purple", "Blue", "Orange", "Black", "Pink", "Green", "Yellow", "Neon green", "Silver" };



                for (int i = 0; i < Student.Length; i++)
                {
                    Console.WriteLine($"{i + 1}: {Student[i]}");

                }

                Console.WriteLine("What student would you like to know more about? (Enter a number 1-10");
                int userInput = int.Parse(Console.ReadLine());

                if (userInput >= 1 && userInput <= 10)
                {
                    //Console.WriteLine($"Okay, you want to know more about {Student[userInput - 1]}");
                }
                else
                {
                    Console.WriteLine("Error. Please enter a number between 1 and 10");
                    return;
                }

                Console.WriteLine($"What would you like to know about {Student[userInput - 1]}?\nHometown, favorite food, or favorite color\n(Enter H for hometown, F for favorite food, C for favorite color.)");

                string homeFoodColor = Console.ReadLine();

                if (homeFoodColor == "H" || homeFoodColor == "h")
                {
                    Console.WriteLine($"{Student[userInput - 1]}'s hometown is {Hometown[userInput - 1]}");
                }
                else if (homeFoodColor == "F" || homeFoodColor == "f")
                {
                    Console.WriteLine($"{Student[userInput - 1]}'s favorite food is {Food[userInput - 1]}");
                }
                else if (homeFoodColor == "C" || homeFoodColor == "c")
                {
                    Console.WriteLine($"{Student[userInput - 1]}'s favorite color is {Color[userInput - 1]}");
                }
                else
                {
                    Console.WriteLine("Please try again. Enter H for hometown, F for favorite food, or C for favorite color.");
                    return;
                }
                Console.WriteLine("Would you like to learn about someone else?\nPress any key to continue or X to quit.");
                string userContinue = Console.ReadLine();
                if (userContinue == "x" || userContinue == "X")
                    playAgain = false;
            }
            Console.WriteLine("Thanks for playing.");
        }
    }
}
            
