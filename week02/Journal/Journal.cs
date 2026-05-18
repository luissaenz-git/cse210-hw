using System;
using System.IO;
using System.Collections.Generic;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    // Create object of type Entry and add it to the list of entries
    

    public Journal()
    {
    
    }

    public void AddEntry(Entry entry)
    {
        Entry _journalEntry = new Entry();

        // We can assign the value of the date to the _date attribute of the journalEntry object

        DateTime theCurrentTime = DateTime.Now;

        _journalEntry._date = theCurrentTime.ToShortDateString();

        //Create object of type PromptGenerator
        PromptGenerator promptGenerator = new PromptGenerator();
        // Now that the object promptGenerator is created with the name promptGenerator
        // We can call the method GetRandomPrompt() from the PromptGenerator class using the local object promptGenerator
        string prompt = promptGenerator.GetRandomPrompt();
        // We can assign the value of the prompt to the _promptText attribute of the journalEntry object
        _journalEntry._promptText = prompt;
        // We can display the value of the _promptText attribute of the journalEntry object to the console
        Console.WriteLine($"{_journalEntry._promptText}");

        _journalEntry._entryText = Console.ReadLine();

        _entries.Add(_journalEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry listed in _entries)
        {
            listed.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
    
        {
            // This will be the CSV header
            outputFile.WriteLine($"Date,Question,Response");
            // This wil use "" and , to format the CSV file
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"\"{entry._date}\",\"{entry._promptText}\",\"{entry._entryText}\"");
            }
        }
    }

    public void LoadFromFile(string file)

    {
        //We clear the previous list created
        _entries.Clear();
        
        //We start reading the file
        string[] lines = System.IO.File.ReadAllLines(file);
        //To skip the header We omit the first line using index 1 to start from the second line
        //for loop allows to use an specific index
        for(int i = 1; i <lines.Length; i++)
        {
            Entry _journalEntry = new Entry();
            // We can split the line into parts using the comma as a delimiter
            // Due to we are using an index, we need to indicate the index here too (this is to omit header)
            string[] parts = lines[i].Split(",");
            // We can erase the csv format to display it
            parts[0] = parts[0].Replace("\"", "");
            parts[1] = parts[1].Replace("\"", "");
            parts[2] = parts[2].Replace("\"", "");
            // We can assign the value of the first part to the _date attribute of the Entry object and so on
            _journalEntry._date = parts[0];
            _journalEntry._promptText = parts[1];
            _journalEntry._entryText = parts[2];
            _entries.Add(_journalEntry);
        }
        
    }









}



