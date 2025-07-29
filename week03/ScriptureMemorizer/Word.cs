public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = true;
    }

    public void Hide()
    {
   
    }

    public void Show()
    {

    }

    public bool Ishidden()
    {
        return true;
    }

    public string GetDisplayText()
    {

        return _text;
    }
}

