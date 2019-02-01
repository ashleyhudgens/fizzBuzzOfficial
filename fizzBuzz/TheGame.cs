using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class TheGame
    {
        public void getWelcome(int x, int y)
        {
            Console.WriteLine("You're playing FizzBuzz! Please enter the first number:");

            for (int z = x; z <= y; z++)
            {
                var userInput = Console.ReadLine();
                verifyInput(userInput, z);
            }
        }

        public void verifyInput(string userInput, int z)
        {
            if (z % 3 == 0 && z % 4 == 0 && z % 5 == 0)
            {
                verifyStringForThreeFourFive(userInput);
            }

            if (z % 3 == 0 && z % 4 == 0)
            {
                verifyStringForThreeFour(userInput);
            }

            if (z % 3 == 0 && 3 % 5 == 0)
            {
                verifyStringForThreeFive(userInput);
            }

            if (z % 3 == 0)
            {
                verifyStringForThree(userInput);
            }

            if (z % 4 == 0 && z % 5 == 0)
            {
                verifyStringForFourFive(userInput);
            }

            if (z % 4 == 0)
            {
                verifyStringForFour(userInput);
            }

            if (z % 5 == 0)
            {
                verifyStringForFive(userInput);
            }
        }

        public void verifyStringForThreeFourFive(string userInput)
        {
            if (userInput.ToLower().Equals("fizzrazzbuzz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }

        }
        public void verifyStringForThreeFour(string userInput)
        {
            if (userInput.ToLower().Equals("fizzrazz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
        public void verifyStringForThreeFive(string userInput)
        {
            if (userInput.ToLower().Equals("fizzbuzz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
        public void verifyStringForThree(string userInput)
        {
            if (userInput.ToLower().Equals("fizz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
        public void verifyStringForFourFive(string userInput)
        {
            if (userInput.ToLower().Equals("razzbuzz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
        public void verifyStringForFour(string userInput)
        {
            if (userInput.ToLower().Equals("razz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
        public void verifyStringForFive(string userInput)
        {
            if (userInput.ToLower().Equals("buzz"))
            {
                Console.WriteLine("Correct!");
            }
            else
            {
                Console.WriteLine("Incorrect. Please try again.");
            }
        }
    }
}
