// Hint: This is the public class Entry syntax

public class Entry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    public Entry()
    {
    }

    public void DisplayNewEntry()
    {
        Console.WriteLine($"({_date}) {_prompt}: {_response}");  
    }
}
