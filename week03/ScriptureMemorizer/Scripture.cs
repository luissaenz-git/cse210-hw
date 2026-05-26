using System.ComponentModel;

public class Scripture
{
    // This reference will be used to store the book, chapter, verse, and end verse of the scripture. 
    // For now it is just an object that is created in the Program.cs file and passed to the Scripture class.
    private Reference _reference;
    private List<Word> _words = new List<Word>();
    private string _text;

    public Scripture (Reference reference, string text)
    {
        _reference = reference;
        _text = text;
        // This will separate the text into individual words and 
        // create a Word object for each word in the text and add it to the list of words.
        foreach (string oneWord in _text.Split(""))
        {
            _words.Add(new Word(oneWord));
        }      

    }

    public void HideRandomWords(int numberToHide)
    {}

    public string GetDisplayText()
    {
        return _reference.GetDisplayText();
    }

    public bool IsCompletelyHidden()
    {
        return false;
    }
}