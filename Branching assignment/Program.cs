using System;

class Program
{
    static void Main()
    {
        // Welcome message to start the program
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt the user for the package weight and convert the input to a double
        Console.Write("Please enter the package weight: ");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the weight is greater than 50
        if (weight > 50)
        {
            // If the weight is greater than 50, display the error message and end the program
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // Exits the program
        }

        // Prompt the user for the package width and convert the input to a double
        Console.Write("Please enter the package width: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package height and convert the input to a double
        Console.Write("Please enter the package height: ");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt the user for the package length and convert the input to a double
        Console.Write("Please enter the package length: ");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the sum of the dimensions (width + height + length) is greater than 50
        if (width + height + length > 50)
        {
            // If the dimensions total is greater than 50, display the error message and end the program
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // Exits the program
        }

        // Calculate the shipping quote: (width * height * length * weight) / 100
        double quote = (width * height * length * weight) / 100;

        // Display the estimated shipping quote, formatted to two decimal places
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

        // Thank the user for using the service
        Console.WriteLine("Thank you!");
    }
}