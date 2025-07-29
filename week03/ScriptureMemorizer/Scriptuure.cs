public class Scripture
{
    private Reference _reference;
    private List<string> _words;

    Scripture(Reference reference, string text)
    {
    
        _reference = reference;
        _words.Add(text);

    }

    public void HideRandomWords(int numberToHide)
    {

        {

        }
        

    }

    public string GetDisplayText()
    {

        return ($"{_reference}: {_words}");
    }

}