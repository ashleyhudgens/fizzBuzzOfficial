using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class TheGame
    {
        public void getWelcome(string x, string y)
        {
            Console.WriteLine("You're playing FizzBuzz!");

            //Console.WriteLine("Multiples of three will print out \"fizz\".");
            //Console.WriteLine("Multiples of four will print out \"razz\".");
            //Console.WriteLine("Multiples of five will print out \"buzz\".");
            //Console.WriteLine("Multiples of three and four will print out \"fizzrazz\".");
            //Console.WriteLine("Multiples of three and five will print out \"fizzbuzz\".");
            //Console.WriteLine("Multiples of four and five will print out \"razzbuzz\".");
            //Console.WriteLine("Multiples of three, four and five will print out \"fizzrazzbuzz\".");


            Console.WriteLine("Please enter the first number.");
            var userInput = Console.ReadLine();

            getUserInput(userInput, x, y);
        }

        public void verifyUserInput(string userInput)
        {

        }

        public void getUserInput(string userInput, string x, string y)
        {
            var userInputAsInt = Convert.ToInt32(userInput);

            if (userInputAsInt % 3 == 0)
            {
                if (userInputAsInt % 4 == 0)
                {
                    if (userInputAsInt % 5 == 0)
                    {                      
                        Console.WriteLine("Correct!");
                    }
                }
            }

            if (userInputAsInt % 4 == 0)
            {
                if (userInputAsInt % 5 == 0)
                {
                    Console.WriteLine("Correct!");
                }
            }

            if (userInputAsInt % 3 == 0)
            {
                if (userInputAsInt % 5 == 0)
                {
                    Console.WriteLine("Correct!");
                }
            }

            if (userInputAsInt % 3 == 0)
            {
                if (userInputAsInt % 4 == 0)
                {
                    Console.WriteLine("Correct!");
                }
            }

            if (userInputAsInt % 3 == 0)
            {
                Console.WriteLine("Correct!");
            }

            if (userInputAsInt % 4 == 0)
            {
                Console.WriteLine("Correct!");
            }

            if (userInputAsInt % 5 == 0)
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForThreeFourFive(string userInput)
        {
            if (userInput == "fizzrazzbuzz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForFourFive(string userInput)
        {
            if (userInput == "razzbuzz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForThreeFour(string userInput)
        {
            if (userInput == "fizzrazz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForThreeFive(string userInput)
        {
            if (userInput == "fizzbuzz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForFive(string userInput)
        {
            if (userInput == "buzz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForFour(string userInput)
        {
            if (userInput == "razz")
            {
                Console.WriteLine("Correct!");
            }
        }

        public void verifyStringIsRightForThree(string userInput)
        {
            if (userInput == "fizz")
            {
                Console.WriteLine("Correct!");
            }
        }
    }
}
