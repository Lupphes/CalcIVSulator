using System;
using IVSMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IVSMathLibraryTests
{
    [TestClass]
    public class IVSMathTests
    {

        // Prepare
        double precision = 0.0000001f;

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void NumberValidation_Overflow_ReturnExeptions()
        {
        }

        [TestMethod]
        public void Add_Calculation_ReturnsEqual()
        {

        }

        [TestMethod]
        public void Substract_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Multiply_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ReturnExeptions()
        {
        }

        [TestMethod]
        public void Divide_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Root_Calculation_ReturnsTrue()
        {
        }
        [TestMethod]
        public void Power_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Inverse_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Sine_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Cosine_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Tangent_Calculation_ReturnsTrue()
        {
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs natural numbers only
         * Returns true if OK
         */
        [TestMethod]
        public void Factorial_Calculation_NaturalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Factorial(1), 0);
            Assert.AreEqual(2, IVSMath.Factorial(2), 0);
            Assert.AreEqual(6, IVSMath.Factorial(3), 0);
            Assert.AreEqual(24, IVSMath.Factorial(4), 0);
            Assert.AreEqual(120, IVSMath.Factorial(5), 0);
            Assert.AreEqual(3628800, IVSMath.Factorial(12), 0);
            Assert.AreEqual(7.25741561530799E+306, IVSMath.Factorial(170), 0);
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs numbers so high that their factorial cannot fit into type double
         * Throws OverflowException
         */
        [TestMethod]
        public void Factorial_Calculation_Overflow_ReturnOverflowException()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(171));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(172));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(200));
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs zero
         * Returns true if OK
         */
        [TestMethod]
        public void Factorial_Calculation_Zero_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Factorial(0), 0);
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs negative numbers
         * Throws exceptions
         */
        [TestMethod]
        public void Factorial_Calculation_NegativeNumbers_ReturnExceptions()
        {
            try
            {
                IVSMath.Factorial(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-3);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-15);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
    }
}
