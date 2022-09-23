using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.UnitTestProject1
{
    [TestClass]
    public class Calculator1UnitTest1
    {
        [TestMethod]
        public void Sum_WithValidInput_ShouldGiveValidResult()//Test Case
        {
            //do not write
            //conditional stmts
            //looping 
            //try catch

            //write simple plan statemwnts

            //AAA
            //A-Arrange
            int a = 10;
            int b = 20;
            //Calculator1 target = new Calculator1();
            int expected = 30;
            //A-Act
            int actual = Calculator1.Sum(a, b);
            //A-Assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void Sum_WithZeroInput_ThrowsExp()
        {
            Calculator1.Sum(0, 0);

        }
    }
}
