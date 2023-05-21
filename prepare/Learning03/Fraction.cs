using System;

public class Fraction
{
    private int _top; // Numerator of the fraction
    private int _bottom; // Denominator of the fraction 

    public Fraction()
    {
        // Default to 1/1 
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber)
    {
        _top = wholeNumber; // Set the numerator as the whole number 
        _bottom = 1; // Set the denominator as 1 
    }

    public Fraction(int top, int bottom)
    {
        _top = top; // Set the numerator
        _bottom = bottom; // Set the denominator
    }

    public string GetFractionString()
    {   
// Returns a string representation of the fraction in the format "numerator/denominator"
// Note that this is not stored as a member variable.
// It is just a temporary local variable that will be computed each time this method is called.
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {

// Returns the decimal value of the fraction as a floating-point number
// Note that this is not stored as a member variable.
// It will be computed each time this method is called.
        return (double)_top / (double)_bottom;
    }
}


