using System;



public class PromptGenerator

{
    //NOTE: In this part attributes are created
    // Create a random number generator to select a random prompt from the list
    public Random _randomNumber = new Random();
    // Create a list of strings to hold the prompts
    public List<String> _prompts = new List<String>();
    
    //NOTE: In this part the constructor is created
    public PromptGenerator()
    {
        // Add prompts to the list of prompts
        _prompts.Add("How did you feel today?");
        _prompts.Add("What was the most interesting part of your day?");
        _prompts.Add("What have you learned today?");
        _prompts.Add("What spiritual experience did you have today?");
        _prompts.Add("What was the achievement of your day?");
    }

    //NOTE: Once class is initialized with its attributes, this method can be used to get a random prompt from the list of prompts
    public string GetRandomPrompt()
    {
        /// Get a random prompt from the list of prompts and return it using Count to get the number of prompts in the list and using the random number generator to select a random prompt from the list
        int index = _randomNumber.Next(0, _prompts.Count);
        // Return the random value from the prompt list, that will be a string value
        return _prompts[index];
    }
}

