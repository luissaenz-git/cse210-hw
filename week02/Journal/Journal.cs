using System;

public class Journal

{
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {
    
    }

    public void AddEntry(Entry entry)
    {
        // Create object of type Entry and add it to the list of entries
        Entry journalEntry = new Entry();

        // We can assign the value of the date to the _date attribute of the journalEntry object

        journalEntry._date = "2026-05-15";

        //Create object of type PromptGenerator
        PromptGenerator promptGenerator = new PromptGenerator();
        // Now that the object promptGenerator is created with the name promptGenerator
        // We can call the method GetRandomPrompt() from the PromptGenerator class using the local object promptGenerator
        string prompt = promptGenerator.GetRandomPrompt();
        // We can assign the value of the prompt to the _promptText attribute of the journalEntry object
        journalEntry._promptText = prompt;
        // We can display the value of the _promptText attribute of the journalEntry object to the console
        Console.WriteLine($"{journalEntry._promptText}");

        journalEntry._entryText = Console.ReadLine();

        _entries.Add(journalEntry);

    }

    public void DisplayAll()
    {
        foreach (Entry listed in _entries)
        {
            listed.Display();
        }
    }

    public void SaveToFile(string file)
    {}

    public void LoadFromFile(string file)
    {}









}



