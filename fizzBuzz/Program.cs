using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fizzBuzz
{
    class Program
    {
        public static void Main(string[] args)
        {
            var arguments = Environment.GetCommandLineArgs();

            var testing = new TheGame();

            string x = arguments[1];
            string y = arguments[2];

            testing.getWelcome(x, y);


















            //var assignArgumentsToVariables = new AssignVariables();

            //assignArgumentsToVariables.setAppropriateValues(arguments);

            Console.ReadLine();
        }
    }
}
