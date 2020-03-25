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
            Assert.ThrowsException<OverflowException>(() => IVSMath.Divide(double.MaxValue, 0.5));
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
            Assert.AreEqual(0, IVSMath.Substract(0, 0), 0);
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
        public void NumberValidation_OverflowPower_ReturnExeption()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Power(double.MaxValue, 5));
        }

        [TestMethod]
        public void Power_CalculationWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(8, IVSMath.Power(2, 3), 0);
            Assert.AreEqual(0, IVSMath.Power(0, 5), 0);
            Assert.AreEqual(1, IVSMath.Power(5, 0), 0);
        }

        [TestMethod]
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

        [TestMethod]
        public void Power_CalculationDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power(2.5, 2), precision);
        }

        [TestMethod]
        public void Power_CalculationNegativeDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power(2.5, -2), precision);
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power((-2.5), 2), precision);
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power((-2.5), -2), precision);
        }

        [TestMethod]
        public void Power_CalculationIrrationalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Power(Math.PI, 2), precision);
        }

        [TestMethod]
        public void Power_Calculation_ReturnsTrue()
        {
        }

        [TestMethod]
        public void Root_Square_RadicandIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(2, IVSMath.Root(4, 2), precision);
            Assert.AreEqual(4, IVSMath.Root(16, 2), precision);
            Assert.AreEqual(2, IVSMath.Root(2, 2) * IVSMath.Root(2, 2), precision);
        }
        [TestMethod]
        public void Root_Square_RadicandRealPositive_ReturnsTrue()
        {
            Assert.AreEqual(3.141592, IVSMath.Root(3.141592, 2) * IVSMath.Root(3.141592, 2), precision);
            Assert.AreEqual(0.5, IVSMath.Root(0.5, 2) * IVSMath.Root(0.5, 2), precision);
            Assert.AreEqual(138.6576, IVSMath.Root(138.6576, 2) * IVSMath.Root(138.6576, 2), precision);
        }
        [TestMethod]
        public void Root_Square_RadicandIntegerNegative_ReturnsExceptions()
        {
            try {
                IVSMath.Root(-2, 2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        public void Root_Square_RadicandRealNegative_ReturnsExceptions()
        {
            try
            {
                IVSMath.Root(-3.141592, 2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        public void Root_Square_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 2), 0);
        }
        [TestMethod]
        public void Root_Square_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 2), 0);
        }
        [TestMethod]
        public void Root_Cube_RadicandIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(3, IVSMath.Root(27, 3), precision);
            Assert.AreEqual(4, IVSMath.Root(64, 3), precision);
            double root = IVSMath.Root(3, 3);
            Assert.AreEqual(3, root * root * root, precision);
        }
        [TestMethod]
        public void Root_Cube_RadicandRealPositive_ReturnsTrue()
        {
            double root;
            root = IVSMath.Root(3.141592, 3);
            Assert.AreEqual(3.141592, root * root * root, precision);
            root = IVSMath.Root(0.58321, 3);
            Assert.AreEqual(0.58321, root * root * root, precision);
            root = IVSMath.Root(1568.13148, 3);
            Assert.AreEqual(1568.13148, root * root * root, precision);
        }
        [TestMethod]
        public void Root_Cube_RadicandIntegerNegative_ReturnsTrue()
        {
            double root;
            root = IVSMath.Root(-27, 3);
            Assert.AreEqual(-3, root, precision);
            root = IVSMath.Root(-64, 3);
            Assert.AreEqual(-4, root, precision);
            root = IVSMath.Root(-3, 3);
            Assert.AreEqual(-3, root * root * root, precision);
        }
        [TestMethod]
        public void Root_Cube_RadicandRealNegative_ReturnsTrue()
        {
            double root;
            root = IVSMath.Root(-3.141592, 3);
            Assert.AreEqual(-3.141592, root * root * root, precision);
            root = IVSMath.Root(-0.58321, 3);
            Assert.AreEqual(-0.58321, root * root * root, precision);
            root = IVSMath.Root(-1568.13148, 3);
            Assert.AreEqual(-1568.13148, root * root * root, precision);
        }
        [TestMethod]
        public void Root_Cube_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 3), 0);
        }
        [TestMethod]
        public void Root_Cube_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 3), 0);
        }
        [TestMethod]
        public void Root_Cube_RadicandNegativeOne_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Root(-1, 3), 0);
        }
        [TestMethod]
        public void Root_FirstDegree_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 1), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 1), 0);
            Assert.AreEqual(42, IVSMath.Root(42, 1), 0);
            Assert.AreEqual(-866, IVSMath.Root(-866, 1), 0);
            Assert.AreEqual(3.141592, IVSMath.Root(3.141592, 1), 0);
            Assert.AreEqual(-3.141592, IVSMath.Root(-3.141592, 1), 0);

        }
        [TestMethod]
        public void Root_VariousDegrees_RadicandPositive_ReturnsTrue()
        {
            double radicand, degree, root, acc;
            radicand = 3154653;
            degree = 17;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = 200848720;
            degree = 88;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = 3.141592;
            degree = 8;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);
            
            radicand = 0.56598;
            degree = 4;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);
        }
        [TestMethod]
        public void Root_VariousDegrees_RadicandNegativeInvalid_ReturnsExceptions()
        {
            try
            {
                IVSMath.Root(-131, 16);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1, 106);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-3.14649871, 1162);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        public void Root_VariousDegrees_RadicandNegativeValid_ReturnsTrue()
        {
            double radicand, degree, root, acc;
            radicand = -3154653;
            degree = 17;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = -200848720;
            degree = 93;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = 3.141592;
            degree = 7;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = 0.56598;
            degree = 5;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);
        }
        [TestMethod]
        public void Root_VariousDegrees_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 13), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 136), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 1987), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 241628), 0);
        }
        [TestMethod]
        public void Root_VariousDegrees_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 13), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 136), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 1987), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 241628), 0);
        }
        public void Root_VariousDegrees_RadicandNegativeOne_Valid_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Root(-1, 13), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 135), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 1987), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 241627), 0);
        }
        [TestMethod]
        public void Root_ZerothDegree_ReturnsExceptions()
        {
            try
            {
                IVSMath.Root(132165, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(134.1234, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-132154, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1657.321564, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(0, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(1, 0);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        public void Root_NegativeDegrees_ReturnsExceptions()
        {
            try
            {
                IVSMath.Root(132165, -1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(134.1234, -127);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-132154, -35);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1657.321564, -42);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(0, -9);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1, -13);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(1, -18);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
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
