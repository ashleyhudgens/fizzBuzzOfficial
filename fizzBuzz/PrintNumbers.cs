using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class PrintNumbers : IPrintNumbers
    {
        public void getPrintClass(int x, int y)
        {
            if (y <= x)
            {
                Console.WriteLine("Range of numbers is invalid.");
            }

            for (int z = x; z <= y; z++)
            {
                if (z % 3 == 0 && z % 4 == 0 && z % 5 == 0)
                {
                    multiplesOfThreeFourFive(z);
                }
                else if (z % 3 == 0 && z % 4 == 0)
                {
                    multiplesOfThreeFour(z);
                }
                else if (z % 3 == 0 && z % 5 == 0)
                {
                    multiplesOfThreeFive(z);
                }
                else if (z % 3 == 0)
                {
                    multiplesOfThree(z);
                }
                else if (z % 4 == 0)
                {
                    multiplesOfFour(z);
                }
                else if (z % 5 == 0)
                {
                    multiplesOfFive(z);
                }
                else
                {
                    Console.WriteLine(z);
                }
            }
        }

        public string multiplesOfThreeFourFive(int z)
        {
            Console.WriteLine("fizzrazzbuzz");
            return "fizzrazzbuzz";
        }

        public string multiplesOfThreeFour(int z)
        {
            Console.WriteLine("fizzrazz");
            return "fizzrazz";
        }

        public string multiplesOfThreeFive(int z)
        {
            Console.WriteLine("fizzbuzz");
            return "fizzbuzz";
        }

        public string multiplesOfFourFive(int z)
        {
            Console.WriteLine("razzbuzz");
            return "razzbuzz";
        }

        public string multiplesOfThree(int z)
        {
            Console.WriteLine("fizz");
            return "fizz";
        }

        public string multiplesOfFour(int z)
        {
            Console.WriteLine("razz");
            return "razz";
        }

        public string multiplesOfFive(int z)
        {
            Console.WriteLine("buzz");
            return "buzz";
        }
    }
}
