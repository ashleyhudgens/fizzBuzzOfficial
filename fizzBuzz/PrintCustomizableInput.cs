using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class PrintCustomizableInput : IPrintCustomizableInput
    {
        public void customInput(Tuple<string, string> customFirstCustomInput, int firstNumber, int secondNumber)
        {
            var multiple = Convert.ToInt32(customFirstCustomInput.Item1);
            var replacement = customFirstCustomInput.Item2;

            for(int z = firstNumber; z <= secondNumber; z++)
            {
                if (z % multiple == 0)
                {
                    Console.WriteLine(replacement);
                }
                else
                {
                    Console.WriteLine(z);
                }
            }
        }

        public void doubleCustomInput(Tuple<string, string> customDoubleInputOne, Tuple<string, string> customDoubleInputTwo, int firstNumber, int secondNumber)
        {
            var multipleOne = Convert.ToInt32(customDoubleInputOne.Item1);
            var multipleTwo = Convert.ToInt32(customDoubleInputTwo.Item1);

            var replacementOne = customDoubleInputOne.Item2;
            var replacementTwo = customDoubleInputTwo.Item2;

            IList multiples = new IList[multipleOne, multipleTwo];

            for (int z = firstNumber; z <= secondNumber; z++)
            {
                if (z % multipleOne == 0 && z % multipleTwo == 0)
                {
                    Console.WriteLine(replacementOne + replacementTwo);
                } 

                else if (z % multipleOne == 0)
                {
                    Console.WriteLine(replacementOne);
                }

                else
                {
                    Console.WriteLine(z);
                }

            }




        }
    }
}
