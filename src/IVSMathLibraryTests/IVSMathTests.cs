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
        public void Inverse_CalculationOnePositive_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Inverse(1), 0);
        }
        [TestMethod]
        public void Inverse_CalculationOneNegative_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Inverse(-1), 0);
        }
        [TestMethod]
        public void Inverse_CalculationZero_ReturnsExceptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Inverse(0));
        }
        [TestMethod]
        public void Inverse_CalculationIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(1.0 / 5.0, IVSMath.Inverse(5), precision);
            Assert.AreEqual(1.0 / 158963.0, IVSMath.Inverse(158963), precision);
            Assert.AreEqual(1.0 / 42.0, IVSMath.Inverse(42), precision);
        }
        [TestMethod]
        public void Inverse_CalculationRealPositiveAbsGreaterThanOne_ReturnsTrue()
        {
            Assert.AreEqual(8.0 / 41.0, IVSMath.Inverse(5.125), precision);
            Assert.AreEqual(1.0 / 158963.45892, IVSMath.Inverse(158963.45892), precision);
            Assert.AreEqual(50.0 / 2121.0, IVSMath.Inverse(42.42), precision);
        }
        [TestMethod]
        public void Inverse_CalculationRealPositiveAbsLessThanOne_ReturnsTrue()
        {
            Assert.AreEqual(25, IVSMath.Inverse(0.04), precision);
            Assert.AreEqual(5000.0 / 823.0, IVSMath.Inverse(0.1646), precision);
            Assert.AreEqual(50.0 / 21.0, IVSMath.Inverse(0.42), precision);
        }
        [TestMethod]
        public void Inverse_CalculationIntegerNegative_ReturnsTrue()
        {
            Assert.AreEqual(-(1.0 / 5.0), IVSMath.Inverse(-5), precision);
            Assert.AreEqual(-(1.0 / 158963.0), IVSMath.Inverse(-158963), precision);
            Assert.AreEqual(-(1.0 / 42.0), IVSMath.Inverse(-42), precision);
        }
        public void Inverse_CalculationRealNegativeAbsGreaterThanOne_ReturnsTrue()
        {
            Assert.AreEqual(-(8.0 / 41.0), IVSMath.Inverse(-5.125), precision);
            Assert.AreEqual(-(1.0 / 158963.45892), IVSMath.Inverse(-158963.45892), precision);
            Assert.AreEqual(-(50.0 / 2121.0), IVSMath.Inverse(-42.42), precision);
        }
        [TestMethod]
        public void Inverse_CalculationRealNegativeAbsLessThanOne_ReturnsTrue()
        {
            Assert.AreEqual(-25, IVSMath.Inverse(-0.04), precision);
            Assert.AreEqual(-(5000.0 / 823.0), IVSMath.Inverse(-0.1646), precision);
            Assert.AreEqual(-(50.0 / 21.0), IVSMath.Inverse(-0.42), precision);
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
