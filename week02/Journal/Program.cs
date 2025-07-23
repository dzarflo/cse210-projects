// added code an extra prompt
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

            
        
        Journal theJournal = new Journal();

        int input = -1;

        Console.WriteLine("Welcome to the Journal Program!");
        while (input != 0)
        {

            Console.WriteLine("Please select one of the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            string number = Console.ReadLine();
            input = int.Parse(number);

            if (input == 1)
            {
                Entry newEntry = new Entry();
                PromptGenerator aPrompt = new PromptGenerator();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                newEntry._date = dateText;

                newEntry._promptText = aPrompt.GetRandomPrompt();
                Console.WriteLine(newEntry._promptText);

                Console.Write("> ");
                newEntry._entryText = Console.ReadLine();

                theJournal.AddEntry(newEntry);
            }

            else if (input == 2)
            {
                theJournal.DisplayAll();
            }

            else if (input == 3)
            {
                Console.Write("Load(Filename): ");
                string file = Console.ReadLine();
                theJournal.LoadFromFile(file);
            }

            else if (input == 4)
            {
                Console.Write("Save to(Filename): ");
                string file = Console.ReadLine();
                theJournal.SaveToFile(file);
            }

            else if (input == 5)
            {
                Console.WriteLine("Come agian soon!");
                break;
            }

            else
            {
                Console.WriteLine("Invalid input.");
            }

        }


    }
}