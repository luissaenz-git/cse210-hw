using System;
using System.Diagnostics.Tracing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");

        int number = -1;

        int major_number = -1;

        List<int> numbers = new List<int>();

        int total = 0;

        while (number != 0)
        {
            Console.Write("Type a number (0 to stop): ");
            number = int.Parse(Console.ReadLine());
            if (number > major_number)
            {
                major_number = number;
            }
            numbers.Add((int)number);
        }

        foreach (int num in numbers)
        {
            total += num;
        }

        double average = (double)total/(numbers.Count-1);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The major number is: {major_number}");

    }
}