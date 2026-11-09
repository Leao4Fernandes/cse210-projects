public class Journal
{

    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine(entry._date);
                outputFile.WriteLine(entry._promptText);
                outputFile.WriteLine(entry._entryText);
            }
        }
    }

    public void LoadFromFile(string filename)
    {
        try
        {
            using (StreamReader inputFile = new StreamReader(filename))
            {
                while (!inputFile.EndOfStream)
                {
                    string date = inputFile.ReadLine();
                    string prompt = inputFile.ReadLine();
                    string entryText = inputFile.ReadLine();
                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = prompt;
                    entry._entryText = entryText;

                    AddEntry(entry);
                }
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
    }
}
