using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Dice
    {

        // Initialize variables and empty array

        int numRolls = 0;
        int[] rollsArray = new int[11];
        Random rand = new Random();
        
        // Constructor to take in the amount of rolls that will be simulated
        public Dice(int num) { 
            numRolls = num;
        }

        // Function to return the results of rolling the dice a bunch of times
        public int[] rollDie()
        {
            for (int i = 0; i < numRolls; i++)
            {

                int DiceOne = rand.Next(1, 7);
                int DiceTwo = rand.Next(1, 7);
                int sumDice = DiceOne + DiceTwo;

                rollsArray[sumDice - 2]++;
            }

            return rollsArray;
        }
    }
}
