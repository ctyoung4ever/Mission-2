using System;
using System.Linq;

class DiceSimulator
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!"); // Prints welcome message
        Console.Write("How many dice rolls would you like to simulate? "); // Asks for user input for number of rolls
        int numRolls = int.Parse(Console.ReadLine()); // Assigns user input to variable numRolls

        int[] rollTotals = new int[13]; // Create an array with 13 spaces to store the number of times each total is thrown. Index 0 not used.

        // simulate dice rolls
        Random rnd = new Random(); // Create new random number generator
        for (int i = 0; i < numRolls; i++)
        {
            int roll1 = rnd.Next(1, 7); // Roll the first die
            int roll2 = rnd.Next(1, 7); // Roll the second die
            int total = roll1 + roll2; // Calculate the total roll
            rollTotals[total]++; // Increment the number of times this total has been rolled
        }

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS"); // Prints the results header
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls."); // Explains the histogram
        Console.WriteLine("Total number of rolls = " + numRolls + "."); // Prints the total number of rolls

        // print histogram
        int totalAsterisks = 0;
        for (int i = 2; i <= 12; i++)
        {
            int percentage = (int)((double)rollTotals[i] / numRolls * 100); // Calculates the percentage of the total rolls for this total
            Console.Write(i + ": "); // Prints the total roll
            int asterisks = (int)Math.Round((double)percentage / 100 * numRolls);
            totalAsterisks += asterisks;
            for (int j = 0; j < asterisks; j++)
            {
                Console.Write("*"); // Prints an asterisk for every 1% of rolls for this total
            }
            Console.WriteLine(); // Prints a new line for the next total
        }
        Console.WriteLine("Total Asterisks Printed :" + totalAsterisks);
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!"); // Prints a goodbye message
    }
}
