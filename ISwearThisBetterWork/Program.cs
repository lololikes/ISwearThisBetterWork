using System;

class Program
{
    static void Main()
    {
        // use inputs how many dice rolls
        Console.WriteLine("Welcome to the dice simulator game!");
        Console.WriteLine("How many dice rolls would you like to simulate?");

        // convert the inputted string to int
        int numRolls = int.Parse(Console.ReadLine());
        Console.WriteLine("you want " + numRolls);

        int[] totalRolls = new int[13];

        // generate random number in for loop 
        Random rnd = new Random(); 
        for (int i = 0; i < numRolls; i++)
        {
            int roll1 = rnd.Next(1, 7);
            int roll2 = rnd.Next(1, 7);
            int total = roll1 + roll2;
            totalRolls[total]++; 
        }
        // display results to user
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("\nEach '*' represents 1% of the total number of rolls.");
        Console.WriteLine("\nTotal number of rolls = " + numRolls + ".");

        // print the histogram 
        for (int i=2; i<=12; i++)
        {
            Console.Write(i + ": ");
            int percent = (int)
            ((double)totalRolls[i] / numRolls * 100);
            for (int w = 0; w < percent; w++)
            {
                Console.Write("*"); 
            }
            Console.WriteLine();
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}