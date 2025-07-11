using System;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");



        string response = "yes";

        while (response == "yes" || response == "Yes" || response == "YES")
        {
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guessNumber = -1;
            int guesses = 0;

            while (magicNumber != guessNumber)
            {
                guesses += 1;

                Console.Write("What is your guess? ");
                string yourGuess = Console.ReadLine();
                guessNumber = int.Parse(yourGuess);

                if (guessNumber == magicNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guesses} guesses.");
                }

                else if (guessNumber > magicNumber)
                {
                    Console.WriteLine("Lower");
                }

                else if (guessNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
            }

            Console.Write("Play again? ");
            response = Console.ReadLine();

        }

    }



}