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

            var callTheGame = new TheGame();

            int x = Convert.ToInt32(arguments[1]);
            int y = Convert.ToInt32(arguments[2]);

            callTheGame.getWelcome(x, y);

            //var assignArgumentsToVariables = new AssignVariables();

            //assignArgumentsToVariables.setAppropriateValues(arguments);

            Console.ReadLine();
        }
    }
}
