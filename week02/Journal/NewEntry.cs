// Hint: This is the public class NewEntry syntax

public class NewEntry
{
    public string _date = "";
    public string _prompt = "";
    public string _response = "";

    public NewEntry()
    {
    }

    public void DisplayNewEntry()
    {
        Console.WriteLine($"({_date}) {_prompt}: {_response}");  
    }
}
