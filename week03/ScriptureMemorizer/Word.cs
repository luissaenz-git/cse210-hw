using System;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;

    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        string hiddenText = "";
        if (_isHidden == true)

        // this will return smae lenght string than the word but with undersocres
        // to do this we create a new string with underscores and the same lenght than the original word
        {
            foreach (char i in _text)
            {
                hiddenText = hiddenText + "_";
            }
            return hiddenText;
        }
        else
        {
            return _text;
        }
    }


}