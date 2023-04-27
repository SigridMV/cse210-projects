using System;
using System.Collections.Generic;
using System.IO;

class Journal
{

    private List<Entry> entries;
    private PromptGenerator promptGenerator;

    public Journal()
    {
        entries = new List<Entry>();
        promptGenerator = new PromptGenerator();

    }

    public void DisplayJournalEntries()
    {
        foreach (Entry entry in entries)
        {
            entry.DisplayEntry();
        }
    }

    public void CreateJournalEntry()
    {
        Entry newEntry = new Entry();

        newEntry._prompt = promptGenerator.GetRandomPrompt();
        Console.WriteLine(newEntry._prompt);

        Console.Write("> ");
        newEntry._response = Console.ReadLine();
        Console.WriteLine();

        newEntry._date = DateTime.Now.ToString("MM/dd/yyyy");

        entries.Add(newEntry);


    }

    public void SaveToCSV(string filename)
    {
        try
        {
            StreamWriter writer = new StreamWriter(filename);

            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.getEntryAsCSV());
            }

            writer.Close();

            Console.WriteLine("Successfully saved!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error saving journal entries to CSV: " + ex.Message);
        }
    }

    public void LoadFromCSV(string loadFilename)
    {
        try
        {
            StreamReader reader = new StreamReader(loadFilename);

            while (!reader.EndOfStream)
            {
                string[] entryData = reader.ReadLine().Split('|');

                if (entryData.Length >= 3)
                {
                    Entry entry = new Entry
                    {
                        _date = entryData[0],
                        _prompt = entryData[1],
                        _response = entryData[2],
                    };
                    entries.Add(entry);
                }
            }

            reader.Close();
            
            Console.WriteLine("Successfully loaded!");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error loading journal entries from CSV: " + ex.Message);
        }
    }
}