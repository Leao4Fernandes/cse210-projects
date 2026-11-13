namespace ScriptureMemorizer;
public class Scripture
{
    private Reference _refer;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference refer, string sentence)
    {
        _refer = refer;

        string[] pieces = sentence.Split(" ");

        foreach ( string piece in pieces)
        {
            Word wd = new Word(piece);
            _words.Add(wd);
        }

    }

    public string GetDisplayText()
    {
        string phrase = "";
        foreach (Word word in _words)
        {
           phrase +=  " " + word.GetDisplayText() ;
        }
        return $"{_refer.GetDisplayText()}{phrase}";
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        
        for (int i = 0; i < numberToHide; i++)
        {
            int position = random.Next(_words.Count);
            _words[position].Hide();
        }

    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;

    }

}