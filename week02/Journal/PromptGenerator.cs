// added two prompts to prompts
using System.Collections.Generic;

public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()

    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        _prompts.Add("What did I achieve today?");
        _prompts.Add("How did I help someone today?");

        Random randomGenerator = new Random();
        int _randomNumber = randomGenerator.Next(0, 6);

        string line = _prompts[_randomNumber];

        Entry anEntry = new Entry();
        anEntry._promptText = line;

        return line;
    }

    


    
}