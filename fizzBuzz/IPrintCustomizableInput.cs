using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    public interface IPrintCustomizableInput
    {
        void customInput(Tuple<string, string> firstCustomInput, int firstNumber, int secondNumber);
    }
}
