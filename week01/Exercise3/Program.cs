using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");

        

        string play_again = "yes";

        while (play_again == "yes")
        {
            Random randomGenerator = new Random();
            int number = randomGenerator.Next(1, 100); 

            int counter = 0;

            //Console.WriteLine($"{number}");

            int magic_number = number;

            int user_guess = 0;

            Console.Write("Please enter your guess (1-100): ");
            user_guess = int.Parse(Console.ReadLine());

            while (user_guess != magic_number)
            {
                if (user_guess > magic_number)
                {
                    Console.WriteLine("Lower");
                    Console.Write("Please enter your guess (1-100): ");
                    user_guess = int.Parse(Console.ReadLine());
                    counter++;
                }
                else if (user_guess < magic_number)
                {
                    Console.WriteLine("Higher");
                    Console.Write("Please enter your guess (1-100): ");
                    user_guess = int.Parse(Console.ReadLine());
                    counter++;
                }
            }

            counter++;
            if (user_guess == magic_number)
            {
                Console.WriteLine($"Congratulations! You guessed the number {magic_number} in {counter} attempts.");
                Console.Write("Do you want to play again? (yes/no): ");
                play_again = Console.ReadLine();
            }
        }
        
        
        Console.WriteLine("Thank you for playing!");

    }
}