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
        public void Power_CalculationWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(8, IVSMath.Power(2, 3), 0);
            Assert.AreEqual(0, IVSMath.Power(0, 5), 0);
            Assert.AreEqual(1, IVSMath.Power(5, 0), 0);
        }

        public void Power_CalculationNegativeWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(-8, IVSMath.Power((-2), 3), 0);
            Assert.AreEqual(16, IVSMath.Power((-2), 4), 0); // Brackets are not going to be implemented

            Assert.AreEqual((1.0 / 8.0), IVSMath.Power(2, -3), precision);
            Assert.AreEqual((1.0 / 16.0), IVSMath.Power(2, -4), precision);
            Assert.AreEqual(-(1.0 / 8.0), IVSMath.Power((-2), -3), precision);
            Assert.AreEqual((1.0 / 16.0), IVSMath.Power((-2), -4), precision);
        }

        [TestMethod]
        public void Power_ArithmeticExceptionNegative_ReturnExeptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Power(0, -5));
        }

        [TestMethod]
        public void Power_ArithmeticExceptionZero_ReturnExeptions()
        {
            try
            {
                IVSMath.Power(0, 0);
                Assert.Fail("No exception was thrown.");
            }
            catch (Exception ex)
            {
                if (ex is AssertFailedException)
                    Assert.Fail("Input 0^0 did not throw exception.");
            }
        }

        public void Power_CalculationDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power(2.5, 2), precision);
        }

        public void Power_CalculationNegativeDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power(2.5, -2), precision);
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power((-2.5), 2), precision);
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power((-2.5), -2), precision);
        }

        public void Power_CalculationIrrationalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Power(Math.PI, 2), precision);
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
    }
}
