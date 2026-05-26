using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");

        Reference newReference = new Reference("Isaias", 1, 1, 2);

        string  scriptureReferenced = "Visión de Isaías hijo de Amoz, la cual vio acerca de Judá y de Jerusalén en los días de Uzías, de Jotam, de Acaz y de Ezequías, reyes de Judá.";

        Scripture newScripture = new Scripture(newReference, scriptureReferenced );

        Console.WriteLine(newScripture.GetDisplayText());

    }
}