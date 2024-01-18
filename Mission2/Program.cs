// Author: Andrew Naumann
// Section 001

using System;

class Program
{
    static void Main()
    {
        int numRolls;
        int[] rollsArray = new int[11];
        Random rand = new Random();

        do
        {
            // Prompt the user for input
            Console.WriteLine("Enter an integer:");

            // Read the user's input as a string
            string rollCount = Console.ReadLine();

            // Try to convert the input to an integer
            if (int.TryParse(rollCount, out numRolls))
            {
                Console.WriteLine("You entered: " + numRolls);
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!IsInt(numRolls));

        Console.WriteLine("Rolling " + numRolls + " times...");

        for (int i = 0; i < numRolls; i++)
        {
            int DiceOne = rand.Next(1, 7);
            int DiceTwo = rand.Next(1, 7);

            int sumDice = DiceOne + DiceTwo;

            rollsArray[sumDice - 2]++;
        }

        for (int i = 0; i < rollsArray.Length; i++ )
        {
            Console.WriteLine((i + 2) + ": " + rollsArray[i]);
        }
    }

   
    static bool IsInt(int num)
    {
        return true; 
    }
}