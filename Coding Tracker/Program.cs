using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");

        // Read input from the user
        string input = Console.ReadLine();
        int number;

        // Validate input
        if (int.TryParse(input, out number))
        {
            // Check if the number is even or odd
            if (number % 2 == 0)
            {
                Console.WriteLine($"{number} is Even.");
            }
            else
            {
                Console.WriteLine($"{number} is Odd.");
            }

            // Display numbers from 1 to the entered number using a for loop
            Console.WriteLine("Counting up to your number:");
            for (int i = 1; i <= number; i++)
            {
                Console.Write(i + " ");
            }
        }
        else
        {
            Console.WriteLine("Invalid number entered.");
        }

        Console.WriteLine("\nPress any key to exit.");
        Console.ReadKey();
    }
}
