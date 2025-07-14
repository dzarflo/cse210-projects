using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Hello World! This is the Exercise4 Project.");


        int userNumber = -1;
        int sum = 0;
        int maxNumber = 0;
        int minNumber = 99999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (userNumber != 0)
        {
            Console.Write("Enter number: ");

            string number = Console.ReadLine();
            userNumber = int.Parse(number);

            if (userNumber != 0)
            {
                numbers.Add(userNumber);
            }
        }

        foreach (int number in numbers)
        {
            sum += number;
            if (number > maxNumber)
            {
                maxNumber = number;
            }

            else if (number < minNumber && number > -1)
            {
                minNumber = number;
            }
        }
        float average = ((float)sum) / numbers.Count;

        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($" The average is: {average}");
        Console.WriteLine($"The largest number is: {maxNumber}");
        Console.WriteLine($"The largest number is: {minNumber}");

        Console.WriteLine("The sorted list is:");
        numbers.Sort();
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}