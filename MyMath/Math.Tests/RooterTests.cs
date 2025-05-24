using Microsoft.VisualStudio.TestTools.UnitTesting;
using Math.Lib;

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
        public void RooterTestNegativeInputx()
        {
            Rooter rooter = new Rooter();
            try
            {
                rooter.SquareRoot(-10);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.Fail();
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
    }
}