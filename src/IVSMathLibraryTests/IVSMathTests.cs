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
