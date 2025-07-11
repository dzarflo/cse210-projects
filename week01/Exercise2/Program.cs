using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");

        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();

        int grade = int.Parse(gradePercentage);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }

        else if (grade >= 80)
        {
            letter = "B";
        }

        else if (grade >= 70)
        {
            letter = "C";
        }

        else if (grade >= 60)
        {
            letter = "D";
        }

        else if (grade < 60)
        {
            letter = "F";
        }

        else
        {
            Console.WriteLine("Invalid input.");
        }

        string sign = "";

        int lastDigit = (grade % 10);

        if ( lastDigit >= 7)
        {
            sign = "+";
        }

        else if (lastDigit > 3)
        {
            sign = "-";
        }

        else
        {
            sign = " ";
        }

        if (letter == "A")
        {
            if (lastDigit >= 7)
            {
                Console.WriteLine($"You got a/an {letter}");
            }

            else
            {
                Console.WriteLine($"You got a/an {letter}{sign}");
            }
        }

        else if (letter == "F")
        {
            Console.WriteLine($"You got a/an {letter}");
        }

        else
        {
            Console.WriteLine($"You got a/an {letter}{sign}");
        }
        if (grade >= 70)
        {
            Console.WriteLine("Well done.");
        }

        else
        {
            Console.WriteLine("You can do better.");
        }
    }
}