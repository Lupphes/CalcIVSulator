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
            // Add
            IVSMath.Add(double.MaxValue, 1);
            IVSMath.Add(double.MinValue, -1);

            // Substract
            IVSMath.Substract(double.MaxValue, -5);
            IVSMath.Substract(double.MinValue, 5);

            // Multiply
            IVSMath.Multiply(double.MaxValue, 2);
            IVSMath.Multiply(double.MinValue, 0.5);

            // Divide
            IVSMath.Divide(double.MaxValue, 0.5);
            IVSMath.Divide(double.MinValue, 0.5);

        }

        [TestMethod]
        public void Add_Calculation_ReturnEqual()
        {

            // Zero
            Assert.AreEqual(IVSMath.Add(0, 0), 0);

            // Positive whole numbers
            Assert.AreEqual(IVSMath.Add(5, 5), 10);
            Assert.AreEqual(IVSMath.Add(0, 5), 5);
            Assert.AreEqual(IVSMath.Add(5, 0), 5);

            // Negative whole numbers
            Assert.AreEqual(IVSMath.Add(-5, -5), -10);
            Assert.AreEqual(IVSMath.Add(0, -5), -5);
            Assert.AreEqual(IVSMath.Add(-5, 0), -5);

            // Positive decimal numbers
            Assert.AreEqual(IVSMath.Add(5.5, 5.6), 11.1);
            Assert.AreEqual(IVSMath.Add(0, 5.4), 5.4);
            Assert.AreEqual(IVSMath.Add(5.6, 0), 5.6);

            // Negative decimal numbers
            Assert.AreEqual(IVSMath.Add(-5.9, -5.1), -11);
            Assert.AreEqual(IVSMath.Add(0, -5.9), -5.9);
            Assert.AreEqual(IVSMath.Add(-5.2, 0), -5.2);

            // Positive whole rational numbers
            Assert.AreEqual(IVSMath.Add(Math.PI, Math.PI), 2 * Math.PI, precision);
            Assert.AreEqual(IVSMath.Add(Math.PI, -Math.PI), Math.PI, precision);

        }

        [TestMethod]
        public void Substract_Calculation_ReturnTrue()
        {
            // Zero
            Assert.AreEqual(IVSMath.Add(0, 0), 0);

            // Positive whole numbers
            Assert.AreEqual(IVSMath.Substract(5, 5), 0);
            Assert.AreEqual(IVSMath.Substract(0, 5), -5);
            Assert.AreEqual(IVSMath.Substract(5, 0), -5);

            // Negative whole numbers
            Assert.AreEqual(IVSMath.Substract(-5, -5), 0);
            Assert.AreEqual(IVSMath.Substract(5, -5), 10);
            Assert.AreEqual(IVSMath.Substract(0, -5), -5);
            Assert.AreEqual(IVSMath.Substract(-5, 0), -5);

            // Positive decimal numbers
            Assert.AreEqual(IVSMath.Substract(5.5, 5.6), 11.1);
            Assert.AreEqual(IVSMath.Substract(0, 5.4), 5.4);
            Assert.AreEqual(IVSMath.Substract(5.6, 0), 5.6);

            // Negative decimal numbers
            Assert.AreEqual(IVSMath.Substract(-5.9, -5.1), -11);
            Assert.AreEqual(IVSMath.Substract(0, -5.9), -5.9);
            Assert.AreEqual(IVSMath.Substract(-5.2, 0), -5.2);

            // Positive whole rational numbers
            Assert.AreEqual(IVSMath.Substract(Math.PI, Math.PI), 0);
            Assert.AreEqual(IVSMath.Substract(Math.PI, -Math.PI), Math.PI, precision);
        }

        [TestMethod]
        public void Multiply_Calculation_ReturnTrue()
        {
            Assert.AreEqual(IVSMath.Multiply(5, 5), 25);
            Assert.AreEqual(IVSMath.Multiply(0, 5), 0);
            Assert.AreEqual(IVSMath.Multiply(5, 0), 0);

            // Negative whole numbers
            Assert.AreEqual(IVSMath.Multiply(-5, -5), 25);
            Assert.AreEqual(IVSMath.Multiply(5, -5), -25);
            Assert.AreEqual(IVSMath.Multiply(-5, 5), -25);
            Assert.AreEqual(IVSMath.Multiply(0, -5), 0);
            Assert.AreEqual(IVSMath.Multiply(-5, 0), 0);

            // Positive decimal numbers
            Assert.AreEqual(IVSMath.Multiply(5.5, 5.6), 30.8);
            Assert.AreEqual(IVSMath.Multiply(0, 5.4), 0);
            Assert.AreEqual(IVSMath.Multiply(5.6, 0), 0);

            // Negative decimal numbers
            Assert.AreEqual(IVSMath.Multiply(-5.9, -5.1), 30.09);
            Assert.AreEqual(IVSMath.Multiply(0, -5.9), 0);
            Assert.AreEqual(IVSMath.Multiply(-5.2, 0), 0);

            // Positive whole rational numbers
            Assert.AreEqual(IVSMath.Multiply(Math.PI, Math.PI), 2 * Math.PI, precision);
            Assert.AreEqual(IVSMath.Multiply(Math.PI, -Math.PI), -2 * Math.PI, precision);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Divide_ByZero_ReturnExeptions()
        {
            IVSMath.Divide(10, 0);
        }

        [TestMethod]
        public void Divide_Calculation_ReturnTrue()
        {
            Assert.AreEqual(IVSMath.Divide(5, 5), 1);
            Assert.AreEqual(IVSMath.Divide(0, 5), 0);

            // Negative whole numbers
            Assert.AreEqual(IVSMath.Divide(-5, -5), 1);
            Assert.AreEqual(IVSMath.Divide(5, -5), -1);
            Assert.AreEqual(IVSMath.Divide(0, -5), 0);

            // Positive decimal numbers
            Assert.AreEqual(IVSMath.Divide(8.6, 4.3), 2);
            Assert.AreEqual(IVSMath.Divide(0, 5.4), 0);

            // Negative decimal numbers
            Assert.AreEqual(IVSMath.Divide(-25.8, -0.2), 129);
            Assert.AreEqual(IVSMath.Divide(0, -5.9), 0);

            // Positive whole rational numbers
            Assert.AreEqual(IVSMath.Divide(Math.PI, Math.PI), 1);
            Assert.AreEqual(IVSMath.Divide(Math.PI, -Math.PI), -1);
        }

        [TestMethod]
        public void Root_Calculation_ReturnTrue()
        {
        }
        [TestMethod]
        public void Power_Calculation_ReturnTrue()
        {
        }

        [TestMethod]
        public void Inverse_Calculation_ReturnTrue()
        {
        }

        [TestMethod]
        public void Sine_Calculation_ReturnTrue()
        {
        }

        [TestMethod]
        public void Cosine_Calculation_ReturnTrue()
        {
        }

        [TestMethod]
        public void Tangent_Calculation_ReturnTrue()
        {
        }
    }
}
