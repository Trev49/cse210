public class Journal
{
    public List<Entry> Entries;

    public Journal()
    {
        Entries = new List<Entry>();
    }

    public void AddEntry(string prompt, string response)
    {
        Entry newEntry = new Entry(prompt, response);
        Entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (Entries.Count == 0)
        {
            Console.WriteLine("It looks like you have no entries. You should write one!");
        }
        else
        {
            foreach (var entry in Entries)
            {
                Console.WriteLine($"{entry.Date.ToShortDateString()} - {entry.Prompt}");
                Console.WriteLine(entry.Response);
                Console.WriteLine();
            }
        }
    }

    public void SaveToFile(string fileName)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var entry in Entries)
                {
                    writer.WriteLine($"{entry.Date.ToShortDateString()}|{entry.Prompt}|{entry.Response}");
                }
            }
            Console.WriteLine($"Your Journal has been saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"There was a problem saving the file as shown: {ex.Message}");
        }
    }

    public void LoadFromFile(string fileName)
    {


        Entries.Clear();

        if (!File.Exists(fileName))
        {
            Console.WriteLine($"Sorry but the file {fileName} does not exist.");
            return;
        }

        foreach (var line in File.ReadLines(fileName))
        {
            var parts = line.Split('|');
            if (parts.Length == 3)
            {
                DateTime date = DateTime.Parse(parts[0]);
                string prompt = parts[1];
                string response = parts[2];
                Entry entry = new Entry(prompt, response) { Date = date };
                Entries.Add(entry);
            }
        }

        Console.WriteLine($"You have sucessfuly loaded the file {fileName}");


    }
}
