using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission2Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            Console.WriteLine("Welcome to the Dice Rolling Simulator!");
            Console.WriteLine("Please enter the number of times you would like to throw the dice: ");
            int numThrown = Int32.Parse(Console.ReadLine());
            int[] myArray = new int[numThrown];
            int[] DiceRolls = new int[13];

            // for loop to initialize rolls 1 and 2, the total, 
            for (int i = 0; i < myArray.Length; i++)
            {
                int Roll1 = random.Next(1, 7);
                int Roll2 = random.Next(1, 7);
                int Total = Roll1 + Roll2;
                DiceRolls[Total] += 1;
            }

            // print 
            for (int i = 2; i < 13; i++)
            {
                int numAsterisks = ((DiceRolls[i] * 100)/ numThrown);
                Console.Write(i + ": ");

                for (int j = 0; j < numAsterisks; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Thank you for using the dice throwing simulator! Goodbye!");
            Console.ReadLine();
        }
    }
}
