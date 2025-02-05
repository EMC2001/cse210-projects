using System;
using System.Collections.Generic;

class Journal
{
    private List<Entry> entries;

    public Journal()
    {
        entries = new List<Entry>();
    }

    public void addEntry(string prompt, string content)
    {
        string date = DateTime.Now.ToString("yyyy-MM-dd");
        Entry newEntry = new Entry(date, prompt, content);
        entries.Add(newEntry);
    }

    public void DisplayEntries()
    {
        if (entries.Count == 0)
        {
            Console.WriteLine("No journal entries found.");
            return;
        }

        Console.WriteLine("\nYour Journal Entries:");
        foreach (var entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void SaveToFile(string filename)
    {
        using (StreamWriter writer = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine($"{entry.Date}|{entry.Prompt}|{entry.UserEntry}");
            }
        }
        Console.WriteLine("Journal saved successfully!");
    }

    public void LoadFromFile(string filename)
    {
        if (!File.Exists(filename))
        {
            Console.WriteLine("File not found!");
            return;
        }

        entries.Clear(); 

        string[] lines = File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                Entry entry = new Entry(parts[0], parts[1], parts[2]);
                entries.Add(entry);
            }
        }
        Console.WriteLine("Journal loaded successfully!");
    }

}