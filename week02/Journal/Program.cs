using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        List<string> prompts = new List<string>();
        prompts.Add("Who was the most interesting person I interacted with today?");
        prompts.Add("What was the best part of my day?");
        prompts.Add("How did I see the hand of the Lord in my life today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("If I had one thing I could do over today, what would it be?");
        prompts.Add("State one thing you are grateful for?");

        Random randomGenerator = new Random();
        int _randomNumber = randomGenerator.Next(0, 5);

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
                NewEntry entry1 = new NewEntry();

                DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                entry1._date = dateText;

                string prompt = prompts[_randomNumber];
                entry1._prompt = prompt;
                Console.WriteLine(prompt);

                Console.Write("> ");
                entry1._response = Console.ReadLine();
            }
        }


    }
}