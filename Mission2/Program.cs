// Author: Andrew Naumann
// Section 001
// Description: simulate rolling dice a bunch of times and display the percentages (represented
// by stars) next to each possible number that can be rolled.

using Mission2;
using System;

class Program
{
    static void Main()
    {
        int numRolls;
        //int[] rollsArray = new int[11];
        float[] percentageArray = new float[11];
        //Random rand = new Random();

        do
        {
            // Present the user with the situation
            Console.WriteLine("You are faced with two dice...\nEnter an integer (This is how many times you will roll the dice):");

            // Get input from the user
            string rollCount = Console.ReadLine();

            // If the user types an integer, start the program

            if (int.TryParse(rollCount, out numRolls))
            {
                Console.WriteLine("You entered: " + numRolls);

                Console.WriteLine("Rolling " + numRolls + " times...");

                // Initialize an instance of the class Dice

                Dice Die = new Dice(numRolls);

                // Store the results of the rolls in a new array to work with here in this class

                int[] rolls = Die.rollDie();

                for (int i = 0; i < rolls.Length; i++)
                {
                    percentageArray[i] = (rolls[i] * 100 / numRolls);
                    int num = (int)percentageArray[i];

                    Console.Write((i + 2) + ": ");

                    for (int j = 0; j < num; j++)
                    {
                        Console.Write("*");
                    }

                    Console.WriteLine(" ");
                }

                Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
            }

        } while (!IsInt(numRolls));
    }

   
    static bool IsInt(int num)
    {
        return true; 
    }
}