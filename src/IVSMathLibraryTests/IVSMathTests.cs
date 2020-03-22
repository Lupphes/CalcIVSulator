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
        public void Power_Calculation_ReturnsTrue()
        {
            // Positive whole numbers
            Assert.AreEqual(IVSMath.Power(2, 3), 8);
            Assert.AreEqual(IVSMath.Power(0, 5), 0);

            // Negative whole numbers
            Assert.AreEqual(IVSMath.Power(-2, 3), -8);
            Assert.AreEqual(IVSMath.Power(-2, 4), -16); // Brackets are not going to be implemented

            Assert.AreEqual(IVSMath.Power(2, -3), 1 / 8);
            Assert.AreEqual(IVSMath.Power(-2, -4), 1 / 16);
            Assert.AreEqual(IVSMath.Power(-2, -3), -(1 / 8));
            Assert.AreEqual(IVSMath.Power(2, -4), -(1 / 16));

            Assert.AreEqual(IVSMath.Power(0, -5), 0);

            // Positive decimal numbers
            Assert.AreEqual(IVSMath.Power(2.5, 2), 6.25);

            // Negative decimal numbers
            Assert.AreEqual(IVSMath.Power(2.5, -2), 1 / 6.25);
            Assert.AreEqual(IVSMath.Power(-2.5, 2), -6.25);
            Assert.AreEqual(IVSMath.Power(-2.5, -2), -( 1 / 6.25));

            // Positive whole rational numbers
            Assert.AreEqual(IVSMath.Power(Math.PI, 2), Math.PI * 2, precision);
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
