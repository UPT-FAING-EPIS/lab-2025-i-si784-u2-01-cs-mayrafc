using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;
using System;

namespace Math.Tests
{
    [TestClass]
    public class RooterTests
    {
        [TestMethod]
        public void BasicRooterTest()
        {
            Rooter rooter = new Rooter();
            double expectedResult = 2.0;
            double input = expectedResult * expectedResult;
            double actualResult = rooter.SquareRoot(input);
            Assert.AreEqual(expectedResult, actualResult, delta: expectedResult / 100);
        }

        [TestMethod]
        public void RooterTestNegativeInput()
        {
            Rooter rooter = new Rooter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-10));
        }

        [TestMethod]
        public void RooterTestNegativeInputWithMessage()
        {
            Rooter rooter = new Rooter();
            var ex = Assert.ThrowsException<ArgumentOutOfRangeException>(() => rooter.SquareRoot(-5));
            StringAssert.Contains(
                ex.Message,
                "El valor ingresado es invalido, solo se puede ingresar números positivos"
            );
        }

        [TestMethod]
        public void RooterTestZeroInput()
        {
            Rooter rooter = new Rooter();
            Assert.ThrowsException<ArgumentOutOfRangeException>(() => rooter.SquareRoot(0));
        }

        [TestMethod]
        public void RooterTestPositiveSmallNumber()
        {
            Rooter rooter = new Rooter();
            double result = rooter.SquareRoot(0.0004);
            Assert.AreEqual(0.02, result, 0.0001);
        }
    }
}
