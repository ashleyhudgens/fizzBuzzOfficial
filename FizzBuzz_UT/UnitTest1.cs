using System;
using fizzBuzz;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_UT
{
    [TestClass]

    public class UnitTest1
    {
        [TestMethod]
        public void Test_Return_For_Multiples_Of_Three_Four_Five()
        {
            var testOne = new PrintNumbers();

            Assert.AreEqual("fizzrazzbuzz", testOne.multiplesOfThreeFourFive(60));
        }

        [TestMethod]
        public void Test_Return_For_Multiples_Of_Three_Four()
        {
            var testTwo = new PrintNumbers();

            Assert.AreEqual("fizzrazz", testTwo.multiplesOfThreeFour(12));
        }
        [TestMethod]

        public void Test_Return_For_Multiples_Of_Three_Five()
        {
            var testThree = new PrintNumbers();

            Assert.AreEqual("fizzbuzz", testThree.multiplesOfThreeFive(15));
        }
        [TestMethod]

        public void Test_Return_For_Multiples_Of_Four_Five()
        {
            var testFour = new PrintNumbers();

            Assert.AreEqual("razzbuzz", testFour.multiplesOfFourFive(20));
        }
        [TestMethod]

        public void Test_Return_For_Multiples_Of_Three()
        {
            var testFive = new PrintNumbers();

            Assert.AreEqual("fizz", testFive.multiplesOfThree(6));
        }
        [TestMethod]

        public void Test_Return_For_Multiples_Of_Four()
        {
            var testSix = new PrintNumbers();

            Assert.AreEqual("razz", testSix.multiplesOfFour(4));
        }
        [TestMethod]
        public void Test_Return_For_Multiples_Of_Five()
        {
            var testSeven = new PrintNumbers();

            Assert.AreEqual("buzz", testSeven.multiplesOfFive(30));
        }
    }
}
