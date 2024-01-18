using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2
{
    internal class Dice
    {

        int numRolls = 0;
        int[] rollsArray = new int[11];
        Random rand = new Random();
        
        public Dice(int num) { 
            numRolls = num;
        }

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
