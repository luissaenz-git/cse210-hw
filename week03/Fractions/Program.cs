using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        //Constructor tests

        Fraction userFraction = new Fraction();

        Fraction userFraction2 = new Fraction(5);

        Fraction userFraction3 = new Fraction(3,4);

        Fraction userFraction4 = new Fraction();

        //Getter and Setter tests

        //Setters

        int topNumber = 0;
        int bottomNumber = 0;

        Console.WriteLine("Enter the top number: ");

        //Converts string number into a number

        topNumber = int.Parse(Console.ReadLine());

        userFraction4.SetTop(topNumber);

        Console.WriteLine("Enter the bottom number: ");
        bottomNumber = int.Parse(Console.ReadLine());

        userFraction4.SetBottom(bottomNumber);

        //Getters

        Console.WriteLine(userFraction.GetFractionString());
        Console.WriteLine(userFraction.GetDecimalValue());
         Console.WriteLine(userFraction2.GetFractionString());
        Console.WriteLine(userFraction2.GetDecimalValue());
         Console.WriteLine(userFraction3.GetFractionString());
        Console.WriteLine(userFraction3.GetDecimalValue());
         Console.WriteLine(userFraction4.GetFractionString());
        Console.WriteLine(userFraction4.GetDecimalValue());

        
        //Getters tests for userFraction4

        //Console.WriteLine("The top number is:");
        //Console.WriteLine(userFraction.GetTop());
        //Console.WriteLine("The bottom number is:");
        //Console.WriteLine(userFraction.GetBottom());

    }
}