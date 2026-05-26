using System;

public class ScriptureLibrary
{
    private List<Scripture> _scriptures = new List<Scripture>();

    public ScriptureLibrary()
    {}

    public void ReadScripture(string filename)
    {
        foreach (string Scripture in File.ReadLines(filename))
        {
            string[] parts = Scripture.Split("|");
            Reference reference = new Reference(parts[0], int.Parse(parts[1]), int.Parse(parts[2]), int.Parse(parts[3]));
            Scripture newScripture = new Scripture(reference, parts[4]);
            _scriptures.Add(newScripture);
        }
    }

    public Scripture GetRandomScripture()
    {
        Random randomSelector = new Random();
        int scriptureIndex = randomSelector.Next(0,_scriptures.Count);
        return _scriptures[scriptureIndex];
    }
}