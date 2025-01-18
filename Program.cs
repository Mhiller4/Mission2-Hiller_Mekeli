
using Mission2;

// Mekeli Hiller Group 2 - 6 Section 2 IS Junior Core 2024-2025 

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the die throwing simulator!");
        Console.WriteLine("How many dice rolls would you like to simulate?");
        string input = Console.ReadLine();
        int numInput; 

        while (!int.TryParse(input, out numInput) || numInput <= 0)
        {
            Console.WriteLine("Invalid input. Please enter a positive integer:");
            input = Console.ReadLine();
        }
        
        // makes an int we can pass through to 2nd class through int.Parse 
       int numRolls = int.Parse(input); 

      

        

        RollDice dice = new RollDice(); // Create a RollDice thing
        int[] rollResults = dice.SimulateRolls(numRolls); // Array to track sums (2-12) 2 is 1s doubled 

        Console.WriteLine("DICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each '*' represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numInput}.\n");

        for (int i = 0; i < rollResults.Length; i++)
        {
            int percentage = (int)((rollResults[i] / (double)numInput) * 100);
            Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}





/* 
 one class
How times to roll the dice
    Get imput 
    for loop, roll dice + store result
    
one class 
for each possible number to be rolled 
    print the number, 
    Caclulate the precentage of the times it was rolled
    print an asterisk for each percent it was rolled 

*/ 
    