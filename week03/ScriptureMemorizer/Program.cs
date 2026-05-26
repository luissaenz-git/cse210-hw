using System;

//Exceeding Requirements
//A new class called ScriptureLibrary was implemented to read a text file with scriptures
//This new class converts each line into a sctipture with a reference and verse(s) so then it can be used by
//the main program. Additional there is Random method on this class that selects a random scripture from the .txt file
//and returns to the main program to be the scripture that will be used to memorize.
//Text file needs to be separated by a "|" so the porgram can differ and index it to assign reference and verse values.
class Program
{
    static void Main(string[] args)
    {
        string userInput = "";

        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        ScriptureLibrary scriptureLibrary = new ScriptureLibrary();

        scriptureLibrary.ReadScripture("scriptures.txt");

        Scripture newScripture = new Scripture();

        newScripture = scriptureLibrary.GetRandomScripture();

        //Reference newReference = new Reference("Isaias", 1, 1, 2);
        //string  scriptureReferenced = "Visión de Isaías hijo de Amoz, la cual vio acerca de Judá y de Jerusalén en los días de Uzías, de Jotam, de Acaz y de Ezequías, reyes de Judá.";
        //Scripture newScripture = new Scripture(newReference, scriptureReferenced );

        int numberToHide = 3;

        Console.Clear();
        Console.WriteLine(newScripture.GetDisplayText());
        Console.WriteLine("Press enter to continue or type 'quit' to exit:");
        userInput = Console.ReadLine();
        
        while (userInput != "quit" && newScripture.IsCompletelyHidden() == false)
        
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