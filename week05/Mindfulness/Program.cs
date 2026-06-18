// Exceeding Requirements: To avoid repeated questions in the Reflecting Activity Class, on the GetRandomQuestion method
// I am using a new list called _availableQuestions which uses the RemoveAt method to remove already used questions.
// This questions were previously copied from the original _questions list to a new _availableQuestions list.

using System;

class Program
{
    static void Main(string[] args)
    {
        int option = 0;
        string menu = """ 
        Menu Options:
            1. Breathing Activity
            2. Reflection Activity
            3. Listing Activity
            4. Quit
        """;
        BreathingActivity a1 = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        ReflectingActivity a2 = new ReflectingActivity("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
        ListingActivity a3 = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        Console.Clear();
         while (option != 4)
        {
            Console.WriteLine(menu);
            Console.Write("Select a choice from the menu: ");
            option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                a1.Run();
            }
            else if (option == 2)
            {
                a2.Run();
            }
            else if (option == 3)
            {
                a3.Run();
            }
            else if (option == 4)
            {}
            else
            {   
                Console.WriteLine("Invalid option. Please select a valid option from the menu.");
            }
        }

    }
}