using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.Write("Please enter your grade (0-100): ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);
        int last_digit = grade % 10;
        string letterGrade = "";
        string sign = "";
        if (grade >= 90)
        {
            letterGrade = "A"; 
        }
        else if (grade >= 80)
        {
            letterGrade = "B";  
        }
        else if (grade >= 70)
        {
            letterGrade = "C";  
        }
        else if (grade >= 60)
        {
            letterGrade = "D"; 
        }
        else
        {
            letterGrade = "F"; 

        }

        if ((letterGrade == "A" && grade <= 96) ||letterGrade == "B" || letterGrade == "C" || letterGrade == "D")
        {
            if (last_digit >= 7)
            {
                sign += "+";
            }
            else if (last_digit <= 3)
            {
                sign += "-";
            }
            else
            {
                sign += "";
            }
        }

        Console.WriteLine($"Your grade is {letterGrade}{sign}");

        if (grade >=70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Sorry, you did not pass the course. Better luck next time!");
        }
    } 
}