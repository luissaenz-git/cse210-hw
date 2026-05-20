using System;

public class Fraction
{
    private int _top = 0;
    private int _bottom = 0;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction (int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction (int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }


    // This getter needs to return a vale for that reason its return is int
    public int GetTop()
        {
            return _top;
        }
    
    //This setter method does not need to return a value, for that reason is void
    public void SetTop (int topNumber)
    {
        _top = topNumber;
    }

    public int GetBottom()
        {
            return _bottom;
        }

    public void SetBottom (int bottomNumber)
    {
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {   
       return _top + "/" + _bottom;
    }

    public double GetDecimalValue()

    {
        // With this double cast, the operation will be executed as double numbers. Without, this operation would result in 0 if the user inputs a small number in the numerator
        return (double) _top/ (double) _bottom;
    }




}