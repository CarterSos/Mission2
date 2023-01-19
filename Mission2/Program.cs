using System;
using System.Collections.Generic;

namespace Mission2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random rand = new Random(); // instance of Random class and initialized dice variables
            int dice1 = 0;
            int dice2 = 0;
            
            Console.WriteLine("Welcome to the dice throwing simulator!\nHow many dice rolls would you like to simulate?");
            string sNumRolls = Console.ReadLine();
            int iNumRolls = int.Parse(sNumRolls);

            int[] myArray2 = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; // declare list array to keep track of possible rolls
            //          index: 0  1  2  3  4  5  6  7  8  9  10   
            //   number value: 2  3  4  5  6  7  8  9  10 11 12
            
            for (int i = 0; i < iNumRolls; i++) // this loop fills the array with counts for each possible roll of the two dice
            {
                dice1 = rand.Next(6); // random number 0 through 5 (will represent index of each possible roll 1-6) OLD WAY --> [dice1 = rand.Next(1, 7);]
                dice2 = rand.Next(6);
                int combo = dice1 + dice2; // possible outcome 0 through 10 representing values of 2-12
                myArray2[combo]++;
            }
            
            for (int i = 0; i < 11; i++) // loops through each possible result and prints number of occurences
            {
                float fNumRolls = (float)iNumRolls; // convert total rolls to float to avoid truncating decimal in int division
                // example:
                // if a number is rolled 35 times out of 100 print 35 stars
                // if a number is rolled 35 times out of 1000 print 3.5 (i.e. 4) stars
                int currentNum = i + 2;
                Console.Write(currentNum + ":  ");
                int j = 0;
                while (j < ((myArray2[i] / fNumRolls) * 100)) // prints stars for each percent of total rolls for this current value
                {
                    Console.Write("*");
                    j += 1;
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}
