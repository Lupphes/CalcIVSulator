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
        public void NumberValidation_OverflowAdd_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Add(double.MaxValue, 1));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Add(double.MinValue, -1));
        }

        [TestMethod]
        public void NumberValidation_OverflowSubstract_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Substract(double.MaxValue, -5));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Substract(double.MinValue, 5));
        }
      
        [TestMethod]
        public void NumberValidation_OverflowMultiply_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Multiply(double.MaxValue, 2));
        }
      
        [TestMethod]
        public void NumberValidation_OverflowDivide_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Divide(double.Epsilon, 5));
        }

        [TestMethod]
        public void Add_CalculationZero_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Add(0, 0), 0);
        }

        [TestMethod]
        public void Add_CalculationWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(10, IVSMath.Add(5, 5), 0);
            Assert.AreEqual(5, IVSMath.Add(0, 5), 0);
            Assert.AreEqual(5, IVSMath.Add(5, 0), 0);
        }

        [TestMethod]
        public void Add_CalculationNegativeWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(-10, IVSMath.Add(-5, -5), 0);
            Assert.AreEqual(-5, IVSMath.Add(0, -5), 0);
            Assert.AreEqual(-5, IVSMath.Add(-5, 0), 0);
        }

        [TestMethod]
        public void Add_CalculationDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(11.1, IVSMath.Add(5.5, 5.6), 0);
            Assert.AreEqual(5.4, IVSMath.Add(0, 5.4), 0);
            Assert.AreEqual(5.6, IVSMath.Add(5.6, 0), 0);
        }

        [TestMethod]
        public void Add_CalculationNegativeDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-11, IVSMath.Add(-5.9, -5.1), 0);
            Assert.AreEqual(-5.9, IVSMath.Add(0, -5.9), 0);
            Assert.AreEqual(-5.2, IVSMath.Add(-5.2, 0), 0);
        }

        [TestMethod]
        public void Add_CalculationIrrationalNumbers_ReturnEqual()
        {
            Assert.AreEqual(2 * Math.PI, IVSMath.Add(Math.PI, Math.PI), precision);
            Assert.AreEqual(0, IVSMath.Add(Math.PI, -Math.PI), 0);
        }

        [TestMethod]
        public void Substract_CalculationZero_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Add(0, 0), 0);
        }

        [TestMethod]
        public void Substract_CalculationWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Substract(5, 5), 0);
            Assert.AreEqual(-5, IVSMath.Substract(0, 5), 0);
            Assert.AreEqual(5, IVSMath.Substract(5, 0), 0);
        }

        [TestMethod]
        public void Substract_CalculationNegativeWholeNumbers_ReturnEqual() {
            Assert.AreEqual(0, IVSMath.Substract(-5, -5), 0);
            Assert.AreEqual(10, IVSMath.Substract(5, -5), 0);
            Assert.AreEqual(5, IVSMath.Substract(0, -5), 0);
            Assert.AreEqual(-5, IVSMath.Substract(-5, 0), 0);
        }

        [TestMethod]
        public void Substract_CalculationDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-0.1, IVSMath.Substract(5.5, 5.6), 0);
            Assert.AreEqual(-5.4, IVSMath.Substract(0, 5.4), 0);
            Assert.AreEqual(5.6, IVSMath.Substract(5.6, 0), 0);
        }

        [TestMethod]
        public void Substract_CalculationNegativeDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-0.8, IVSMath.Substract(-5.9, -5.1));
            Assert.AreEqual(5.9, IVSMath.Substract(0, -5.9));
            Assert.AreEqual(-5.2, IVSMath.Substract(-5.2, 0));
        }

        [TestMethod]
        public void Substract_CalculationIrrationalNumbers_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Substract(Math.PI, Math.PI), 0);
            Assert.AreEqual(2 * Math.PI, IVSMath.Substract(Math.PI, -Math.PI), precision);
            Assert.AreEqual(-2 * Math.PI, IVSMath.Substract(-Math.PI, Math.PI), precision);
            Assert.AreEqual(0, IVSMath.Substract(-Math.PI, -Math.PI), 0);
        }

        [TestMethod]
        public void Multiply_CalculationZero_ReturnTrue()
        {
            Assert.AreEqual(0, IVSMath.Multiply(0, 0), 0);
        }

        [TestMethod]
        public void Multiply_CalculationWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(25, IVSMath.Multiply(5, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(5, 0), 0);
        }

        [TestMethod]
        public void Multiply_CalculationNegativeWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(25, IVSMath.Multiply(-5, -5), 0);
            Assert.AreEqual(-25, IVSMath.Multiply(5, -5), 0);
            Assert.AreEqual(-25, IVSMath.Multiply(-5, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, -5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(-5, 0), 0);
        }

        [TestMethod]
        public void Multiply_CalculationDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(30.8, IVSMath.Multiply(5.5, 5.6), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, 5.4), 0);
            Assert.AreEqual(0, IVSMath.Multiply(5.6, 0), 0);
        }

        [TestMethod]
        public void Multiply_CalculationNegativeDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(30.09, IVSMath.Multiply(-5.9, -5.1), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, -5.9), 0);
            Assert.AreEqual(0, IVSMath.Multiply(-5.2, 0), 0);
        }

        [TestMethod]
        public void Multiply_CalculationIrrationalNumbers_ReturnTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Multiply(Math.PI, Math.PI), precision);
            Assert.AreEqual(Math.PI * -Math.PI, IVSMath.Multiply(Math.PI, -Math.PI), precision);
            Assert.AreEqual(-Math.PI * Math.PI, IVSMath.Multiply(-Math.PI, Math.PI), precision);
            Assert.AreEqual(-Math.PI * -Math.PI, IVSMath.Multiply(-Math.PI, -Math.PI), precision);
        }

        [TestMethod]
        public void Divide_ByZero_ReturnExeptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Divide(10, 0));
        }

        [TestMethod]
        public void Divide_CalculationWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(5, 5), 0);
            Assert.AreEqual(0, IVSMath.Divide(0, 5), 0);
        }

        [TestMethod]
        public void Divide_CalculationNegativeWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(-5, -5), 0);
            Assert.AreEqual(-1, IVSMath.Divide(5, -5), 0);
            Assert.AreEqual(0, IVSMath.Divide(0, -5), 0);
        }

        [TestMethod]
        public void Divide_CalculationDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(2, IVSMath.Divide(8.6, 4.3), precision);
            Assert.AreEqual(0, IVSMath.Divide(0, 5.4), 0);
        }

        [TestMethod]
        public void Divide_CalculationNegativeDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(129, IVSMath.Divide(-25.8, -0.2), precision);
            Assert.AreEqual(0, IVSMath.Divide(0, -5.9), 0);
        }

        [TestMethod]
        public void Divide_CalculationIrrationalNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(Math.PI, Math.PI));
            Assert.AreEqual(-1, IVSMath.Divide(Math.PI, -Math.PI));
            Assert.AreEqual(-1, IVSMath.Divide(-Math.PI, Math.PI));
            Assert.AreEqual(1, IVSMath.Divide(-Math.PI, -Math.PI));
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
