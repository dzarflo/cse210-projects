public class Entry
{

    public string _date;
    public string _promptText;
    public string _entryText;
    
    public void DisplayNewEntry()
    {
        Console.WriteLine($"({_date}) {_promptText}:");
        Console.WriteLine(_entryText);
    }
}
