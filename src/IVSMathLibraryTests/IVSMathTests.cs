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
            Assert.AreEqual(0, IVSMath.Add(0, 0));

            // Positive whole numbers
            Assert.AreEqual(10, IVSMath.Add(5, 5));
            Assert.AreEqual(5, IVSMath.Add(0, 5));
            Assert.AreEqual(5, IVSMath.Add(5, 0));

            // Negative whole numbers
            Assert.AreEqual(-10, IVSMath.Add(-5, -5));
            Assert.AreEqual(-5, IVSMath.Add(0, -5));
            Assert.AreEqual(-5, IVSMath.Add(-5, 0));

            // Positive decimal numbers
            Assert.AreEqual(11.1, IVSMath.Add(5.5, 5.6));
            Assert.AreEqual(5.4, IVSMath.Add(0, 5.4));
            Assert.AreEqual(5.6, IVSMath.Add(5.6, 0));

            // Negative decimal numbers
            Assert.AreEqual(-11, IVSMath.Add(-5.9, -5.1));
            Assert.AreEqual(-5.9, IVSMath.Add(0, -5.9));
            Assert.AreEqual(-5.2, IVSMath.Add(-5.2, 0));

            // Positive whole rational numbers
            Assert.AreEqual(2 * Math.PI, IVSMath.Add(Math.PI, Math.PI), precision);
            Assert.AreEqual(Math.PI, IVSMath.Add(Math.PI, -Math.PI), precision);

        }

        [TestMethod]
        public void Substract_Calculation_ReturnTrue()
        {
            // Zero
            Assert.AreEqual(0, IVSMath.Add(0, 0));

            // Positive whole numbers
            Assert.AreEqual(0, IVSMath.Substract(5, 5));
            Assert.AreEqual(-5, IVSMath.Substract(0, 5));
            Assert.AreEqual(-5, IVSMath.Substract(5, 0));

            // Negative whole numbers
            Assert.AreEqual(0, IVSMath.Substract(-5, -5));
            Assert.AreEqual(10, IVSMath.Substract(5, -5));
            Assert.AreEqual(-5, IVSMath.Substract(0, -5));
            Assert.AreEqual(-5, IVSMath.Substract(-5, 0));

            // Positive decimal numbers
            Assert.AreEqual(11.1, IVSMath.Substract(5.5, 5.6));
            Assert.AreEqual(5.4, IVSMath.Substract(0, 5.4));
            Assert.AreEqual(5.6, IVSMath.Substract(5.6, 0));

            // Negative decimal numbers
            Assert.AreEqual(-11, IVSMath.Substract(-5.9, -5.1));
            Assert.AreEqual(-5.9, IVSMath.Substract(0, -5.9));
            Assert.AreEqual(-5.2, IVSMath.Substract(-5.2, 0));

            // Positive whole rational numbers
            Assert.AreEqual(0, IVSMath.Substract(Math.PI, Math.PI));
            Assert.AreEqual(Math.PI, IVSMath.Substract(Math.PI, -Math.PI), precision);
        }

        [TestMethod]
        public void Multiply_Calculation_ReturnTrue()
        {
            Assert.AreEqual(25, IVSMath.Multiply(5, 5));
            Assert.AreEqual(0, IVSMath.Multiply(0, 5));
            Assert.AreEqual(0, IVSMath.Multiply(5, 0));

            // Negative whole numbers
            Assert.AreEqual(25, IVSMath.Multiply(-5, -5));
            Assert.AreEqual(-25, IVSMath.Multiply(5, -5));
            Assert.AreEqual(-25, IVSMath.Multiply(-5, 5));
            Assert.AreEqual(0, IVSMath.Multiply(0, -5));
            Assert.AreEqual(0, IVSMath.Multiply(-5, 0));

            // Positive decimal numbers
            Assert.AreEqual(30.8, IVSMath.Multiply(5.5, 5.6));
            Assert.AreEqual(0, IVSMath.Multiply(0, 5.4));
            Assert.AreEqual(0, IVSMath.Multiply(5.6, 0));

            // Negative decimal numbers
            Assert.AreEqual(30.09, IVSMath.Multiply(-5.9, -5.1));
            Assert.AreEqual(0, IVSMath.Multiply(0, -5.9));
            Assert.AreEqual(0, IVSMath.Multiply(-5.2, 0));

            // Positive whole rational numbers
            Assert.AreEqual(2 * Math.PI, IVSMath.Multiply(Math.PI, Math.PI), precision);
            Assert.AreEqual(-2 * Math.PI, IVSMath.Multiply(Math.PI, -Math.PI), precision);
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
            Assert.AreEqual(1, IVSMath.Divide(5, 5));
            Assert.AreEqual(0, IVSMath.Divide(0, 5));

            // Negative whole numbers
            Assert.AreEqual(1, IVSMath.Divide(-5, -5));
            Assert.AreEqual(-1, IVSMath.Divide(5, -5));
            Assert.AreEqual(0, IVSMath.Divide(0, -5));

            // Positive decimal numbers
            Assert.AreEqual(2, IVSMath.Divide(8.6, 4.3));
            Assert.AreEqual(0, IVSMath.Divide(0, 5.4));

            // Negative decimal numbers
            Assert.AreEqual(129, IVSMath.Divide(-25.8, -0.2));
            Assert.AreEqual(0, IVSMath.Divide(0, -5.9));

            // Positive whole rational numbers
            Assert.AreEqual(1, IVSMath.Divide(Math.PI, Math.PI));
            Assert.AreEqual(-1, IVSMath.Divide(Math.PI, -Math.PI));
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
