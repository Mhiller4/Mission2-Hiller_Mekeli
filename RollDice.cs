namespace Mission2;
// Keeps us in the same directory 

public class RollDice
//Second class to roll the dice 
{
    private Random _random = new Random();

    public int[] SimulateRolls(int numRolls)
    {
       
        int[] rollResults = new int[11]; // array of 11 spots, 0 = 1 so 12 -1 
        
        for (int i = 0; i < numRolls; i++)
        {
            int die1 = _random.Next(1, 7);
            int die2 = _random.Next(1, 7);
            
           //  Console.WriteLine($"Die1: {die1}, Die2: {die2}"); Unquote this line to see how the process works in console. 
           
           
            int sum = die1 + die2; 
            rollResults[sum - 2]++; // Increment count for the rolled sum
            // ^^ same as rollResults[result - 2] = rollResults[result - 2] + 1;  
        }

        return rollResults; 

    }
}