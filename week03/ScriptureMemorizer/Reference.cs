namespace ScriptureMemorizer;
public class Reference
{
    private string _bookName;
    private int _chapterNumber;
    private int _startingVerse;
    private int _endingVerse;

    public Reference(string bookName, int chapterNumber, int verse)
    {
        _endingVerse = 0;

        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startingVerse = verse;

    }

    public Reference(string bookName, int chapterNumber, int startingVerse, int endingVerse)
    {
        _bookName = bookName;
        _chapterNumber = chapterNumber;
        _startingVerse = startingVerse;
        _endingVerse = endingVerse;
    }

    public string GetDisplayText()
    {
        string text = "";
        if (_endingVerse == 0)
        {
            text = $"{_bookName} {_chapterNumber}:{_startingVerse}";
        }

        else
        {
            text = $"{_bookName} {_chapterNumber}: {_startingVerse}-{_endingVerse}";
        }

        return text;
    }
}