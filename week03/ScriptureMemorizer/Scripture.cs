using System.ComponentModel;

public class Scripture
{
    // This reference will be used to store the book, chapter, verse, and end verse of the scripture. 
    // For now it is just an object that is created in the Program.cs file and passed to the Scripture class.
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;

    public Scripture ()
    {}

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        // This will separate the text into individual words and 
        // create a Word object for each word in the text and add it to the list of words.
        foreach (string oneWord in _text.Split(" "))
        {
            _words.Add(new Word(oneWord));
        }      

    }

    public void HideRandomWords(int numberToHide)
    {
        Random randomNumber = new Random();
        int randomIndex = randomNumber.Next(0, _words.Count);
        int hiddenWords = 0;
        while (hiddenWords < numberToHide)
        {
            //Hide if it is not hidden
            if (_words[randomIndex].IsHidden() == false)
            {
                _words[randomIndex].Hide();
                hiddenWords++;
            }
            //Generate a new random index if the index is already hidden
            else
            {
                randomIndex = randomNumber.Next(0, _words.Count);
            }
        }
    }

    public string GetDisplayText()
    {
        string displayText = "";
        foreach (Word word in _words) {
            displayText = displayText + " " + word.GetDisplayText();
        }   
        return _reference.GetDisplayText() + " " + displayText;                 
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        // This will review each word, if in that review it founds a hidden word
        // It directly returns false and ends the method
        // If after reviewing all the words it does not find any hidden word, 
        // it will return true
        {
            if (word.IsHidden() == false)
            {
                return false;
            }
        }
        return true;
    }
}