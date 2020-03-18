using System;
using IVSMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IVSMathLibraryTests
{
    [TestClass]
    public class IVSMathTests
    {
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
