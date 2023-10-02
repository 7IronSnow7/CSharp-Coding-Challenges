using System;

public class CriticalRollApp
{
    // Heres how to print it to the console
    static void Main(string[] args)
    {
        Random Dice = new Random();
        diceRolls(Dice);
    }
    public static List<int> diceRolls(Random dice)
    {
        // Storage for dice rolls
        var diceRolls = new List<int>();
        var previousRoll = 0;
        int roll;
        // Iterate through 10 rolls
        for (var i = 0; i < 10; i++)
        {
            do
            {
                // 20 Sided dice
                roll = dice.Next(1, 21);
            } while (roll == previousRoll); // eliminates possibility of consecutive duplicate rolls
            diceRolls.Add(roll);
            previousRoll = roll;

            // Clarifying which is critical failure and critical success
            if (roll == 1)
            {
                Console.WriteLine($"{1} = critical failure");
            }
            else if (roll == 20)
            {
                Console.WriteLine($"{20} = critical success");
            }
            else
            {
                Console.WriteLine(roll);
            }
        }
        Console.WriteLine("Sorted dice list");
        diceRolls.Sort();
        foreach (var die in diceRolls)
        {
            Console.WriteLine(die);
        }

        return diceRolls;
    }
}
/*
 Critical Roll Application:

Write a C# console application that uses a method that will roll a 20-sided dice a total of 10 times, making sure that no 2 subsequent rolls are the same. 
Store these values and then use a bubble sorting method to sort the values from lowest to highest. 
Count the occurrences of critical failures (1) and critical successes (20). 
Display the series of rolls, along with the counts of the critical rolls respectively.
 
Pseudo code:
Storage for dice 

Rolling the dice and the random output, creating an array of numbers. 
    Keeping in mind no 2 rolls can be the same.

Will use bubble sort list to put into list of low to high

Distinguish between:    
    Critical failure
    Critical success

Count the rolls.
    As well as critical rolls

Display to console.
 */