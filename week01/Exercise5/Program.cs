using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");
        {
            DisplayWelcome();
            string name = PromptUserName();
            int number = PromptUserNumber();

            int squaredNumber = SquareNumber(number);

            DisplayReult(name, squaredNumber);
        }
        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Name: ");
            string name = Console.ReadLine();
            return name;
        }

        static int PromptUserNumber()
        {
            Console.Write("Age: ");
            string ageString = Console.ReadLine();
            int age = int.Parse(ageString);
            return age;
        }

        static int SquareNumber(int age)
        {
            int square = age * age;
            return square;
        }

        static void DisplayReult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }

    }
}