// added code to generate display text.


public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;
    private string _quotation;

    Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _quotation = $"{_book} {_chapter}: {_verse}";

    }

    Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
        _quotation = $"{_book} {_chapter}: {_verse}-{_endVerse}";

    }

    public string GetDisplayText()
    {
        return _quotation;
    }


}