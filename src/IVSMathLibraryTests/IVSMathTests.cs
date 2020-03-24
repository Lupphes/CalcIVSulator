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
        public void Add_Calculation_ReturnsEqual()
        {
            // Arrange 
            double result;
            double expected = 10;

            // Act
            result = IVSMath.Add(5, 5);

            // Assert
            Assert.AreEqual(result, expected);
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
            Assert.AreEqual(8, IVSMath.Power(2, 3));
            Assert.AreEqual(0, IVSMath.Power(0, 5));
        }

        public void Power_CalculationNegativeWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(-8, IVSMath.Power(-2, 3));
            Assert.AreEqual(16, IVSMath.Power(-2, 4)); // Brackets are not going to be implemented

            Assert.AreEqual(1 / 8, IVSMath.Power(2, -3));
            Assert.AreEqual(1 / 16, IVSMath.Power(-2, -4));
            Assert.AreEqual(-(1 / 8), IVSMath.Power(-2, -3));
            Assert.AreEqual(-(1 / 16), IVSMath.Power(2, -4));

            Assert.AreEqual(0, IVSMath.Power(0, -5));
        }

        public void Power_CalculationDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(6.25, IVSMath.Power(2.5, 2));
        }

        public void Power_CalculationNegativeDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(1 / 6.25, IVSMath.Power(2.5, -2));
            Assert.AreEqual(-6.25, IVSMath.Power(-2.5, 2));
            Assert.AreEqual(-(1 / 6.25), IVSMath.Power(-2.5, -2));
        }

        public void Power_CalculationRationalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(Math.PI * 2, IVSMath.Power(Math.PI, 2), precision);
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
