// EXCEEDING REQUIREMENTS
// 1. CSV Format: Instead of using a simple separator like,
//    The journal is being saved using "" and , to format the file correctly.
//    The user can save the file as a .csv file by typing the filename with the .csv extension,
//    which allows the file to be opened in Excel.
//
// 2. CSV Header: A header row is included ("Date,Question,Response")
//    in the CSV file generated so the file can be read correctly when opened in Excel.
//
// 3. Auto Date: DateTime.Now is being used to automatically record
//    the date of each entry without asking the user to type it or the need to be hardcoded.

using System;

class Program
{
    static void Main(string[] args)


    {
       
        Console.WriteLine("Hello World! This is the Journal Project.");

         // empty string variable to hold the user's menu option
        string option = "";
        // Create an object of type Journal to hold the user's journal entries
        // Note: It is important to create the object outside of the while loop so it can be used for each option
        Journal userJournal = new Journal();
        string fileName = "";

        while (option != "5")
        {
            // Display menu options
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            
            Console.Write("What would you like to do? ");
            option = Console.ReadLine();

            if (option == "1")
            {
                userJournal.AddEntry(new Entry());
            }
            else if (option == "2")
            {
                // userJournal is the object created and this object has an attribute called _entries 
                // that is a list of type Entry
                // so we can use the Count method 
                // to get the number of entries in the list
                // if the number of entries is 0, we can display a message to the user 
                if (userJournal._entries.Count == 0)
                {
                    Console.WriteLine("Your journal is empty. Please write an entry before trying to display it.");
                }
                else
                {
                    userJournal.DisplayAll();
                }
            }
            else if (option == "3")
            {
                // Load the journal
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                userJournal.LoadFromFile(fileName);

            }
            else if (option == "4")
            {
                // Save the journal
                Console.WriteLine("What is the filename?");
                fileName = Console.ReadLine();
                userJournal.SaveToFile(fileName);
            }

            else {
                Console.WriteLine("Invalid option. Please select a valid option from the menu.");
            }
        }

        Console.WriteLine("Thank you for using the Journal App! See you tomorrow! :)");
    }
}