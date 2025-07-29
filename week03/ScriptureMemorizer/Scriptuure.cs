public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    Scripture(Reference reference, Word text)
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