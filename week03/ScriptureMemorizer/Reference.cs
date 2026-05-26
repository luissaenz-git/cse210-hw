using System;
using System.Data;
using System.Dynamic;

public class Reference
{
    private string _book = "";
    private int _chapter = 0;
    private int _verse = 0;
    private int _endVerse = 0;


    public Reference (string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference (string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        //This allows the reference to be displayed in the correct format. If the user does not input an end verse, 
        // it will just display the book, chapter, and verse. 
        // If the user does input an end verse, it will display the book, chapter, verse, and end verse.
        if (_endVerse == 0)
        {
            return (string) _book + " " + _chapter + ":" + _verse;  
        }
        else
            return (string) _book + " " + _chapter + ":" + _verse + "-" + _endVerse;
    }

    //public void SetBook(string book)
    //{
    //    _book = book;
    //}
    //public void SetChapter(int chapter)
    //{
    //    _chapter = chapter;
    //}
    //public void SetVerse(int verse)
    //{
    //    _verse = verse;
    //}
    //public void SetEndVerse(int endVerse)
    //{
    //    _endVerse = endVerse;
    //}
}