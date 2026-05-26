using System;

class Program
{
    static void Main(string[] args)
    {
        string userInput = "";
        

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference newReference = new Reference("Isaias", 1, 1, 2);

        string  scriptureReferenced = "Visión de Isaías hijo de Amoz, la cual vio acerca de Judá y de Jerusalén en los días de Uzías, de Jotam, de Acaz y de Ezequías, reyes de Judá.";

        Scripture newScripture = new Scripture(newReference, scriptureReferenced );

        int numberToHide = 3;

        Console.Clear();
        Console.WriteLine(newScripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to exit:");
        userInput = Console.ReadLine();
        
        while (userInput != "quit" || newScripture.IsCompletelyHidden() == false)
        
        {
            
            // Enter into the console is equal to send an empty rsponse, userInput can be defined as empty
            if (userInput == "")
            {
                Console.Clear();
                newScripture.HideRandomWords(numberToHide);
                Console.WriteLine(newScripture.GetDisplayText()); 
                Console.WriteLine("Press enter to continue or type 'quit' to exit:");
                userInput = Console.ReadLine();
            }
            // If quit is typed, the porgram will change the user input status and end
        
        }
       
        

    }
}