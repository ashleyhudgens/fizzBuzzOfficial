using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public class AssignVariables
    {
        public void setAppropriateValues(string[] customVariables)
        {
            var first = customVariables[1];
            var second = customVariables[2];
            int firstNumber = Convert.ToInt32(first);
            int secondNumber = Convert.ToInt32(second);


            if (customVariables.Length == 3)
            {
                var printRange = new PrintNumbers();
                printRange.getPrintClass(firstNumber, secondNumber);
            }

            else if (customVariables.Length == 5)
            {
                var firstMultiple = customVariables[3];
                var firstReplacement = customVariables[4];
                var firstCustomTuple = Tuple.Create<string, string>(firstMultiple, firstReplacement);

                var printFirstCustom = new PrintCustomizableInput();

                printFirstCustom.customInput(firstCustomTuple, firstNumber, secondNumber);
            }
            else if (customVariables.Length == 7)
            {
                var firstMultiple = customVariables[3];
                var firstReplacement = customVariables[4];
                var firstCustomTuple = Tuple.Create<string, string>(firstMultiple, firstReplacement);


                var secondMultiple = customVariables[5];
                var secondReplacement = customVariables[6];
                var secondCustomTuple = Tuple.Create<string, string>(secondMultiple, secondReplacement);

                var printSecondCustom = new PrintCustomizableInput();

                printSecondCustom.doubleCustomInput(firstCustomTuple, secondCustomTuple, firstNumber, secondNumber);
            }
            else
            {
                Console.WriteLine("Invalid Parameters");
            }
        }
    }
}
