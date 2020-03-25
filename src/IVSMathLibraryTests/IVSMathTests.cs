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
        public void Inverse_Calculation_ReturnsTrue()
        {
        }

        /*
         * Tests IVSMath.Sine method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        public void Sine_Calculation_Integers_ReturnsTrue()
        {
            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(0, IVSMath.Sine(i * Math.PI), precision);       // sin(i * PI) = 0

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(1, IVSMath.Sine((Math.PI / 2) + (2 * i * Math.PI)), precision);   // sin(PI/2 + 2iPI) = 1

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(-1, IVSMath.Sine(-(Math.PI/2) + (2 * i * Math.PI)), precision);     // sin(-PI/2 + 2iPI) = -1  
        }

        /*
         * Tests IVSMath.Sine method
         * Inputs decimal numbers, expects decimal number as a result
         * Return true if OK
         */
        [TestMethod]
        public void Sine_Calculation_DecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(0.8414709, IVSMath.Sine(1), precision);
            Assert.AreEqual(0.9092974, IVSMath.Sine(2), precision);
            Assert.AreEqual(-0.7568024, IVSMath.Sine(4), precision);
            Assert.AreEqual(-0.9589242, IVSMath.Sine(5), precision);

            Assert.AreEqual(0.2474039, IVSMath.Sine(0.25), precision);
            Assert.AreEqual(-0.9999232, IVSMath.Sine(4.7), precision);
        }

        /*
         * Tests IVSMath.Sine method
         * Inputs decimal numbers, tests periodicity of values
         * Return true if OK
         */
        [TestMethod]
        public void Sine_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            double sine = 0.0;

            for(int i = 0; i < 5; ++i)
            {
                sine = IVSMath.Sine(values[i]);
                for (int j = -2; j < 2; ++j)
                    Assert.AreEqual(sine, IVSMath.Sine(values[i] + 2 * j * Math.PI), precision);    // sin(1.5) = sin(1.5 + 2jPI)
            }
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        public void Cosine_Calculation_Integers_ReturnsTrue()
        {
            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(0, IVSMath.Cosine((Math.PI / 2 ) + i * Math.PI), precision);       // cos(PI/2 + i*PI) = 0

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(1, IVSMath.Cosine(2 * i * Math.PI), precision);   // cos(2iPI) = 1

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(-1, IVSMath.Sine(Math.PI + 2 * i * Math.PI), precision);     // cos(PI + 2iPI) = -1  
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs decimal numbers, expects decimal number as a result
         * Return true if OK
         */
        [TestMethod]
        public void Cosine_Calculation_DecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(0.5403020, IVSMath.Cosine(1), precision);
            Assert.AreEqual(-0.4161468, IVSMath.Cosine(2), precision);
            Assert.AreEqual(-0.6536436, IVSMath.Cosine(4), precision);
            Assert.AreEqual(0.2836621, IVSMath.Cosine(5), precision);

            Assert.AreEqual(0.9689124, IVSMath.Cosine(0.25), precision);
            Assert.AreEqual(-0.0123886, IVSMath.Cosine(4.7), precision);
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs decimal numbers, tests periodicity of values
         * Return true if OK
         */
        [TestMethod]
        public void Cosine_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            double cosine = 0.0;

            for (int i = 0; i < 5; ++i)
            {
                cosine = IVSMath.Cosine(values[i]);
                for (int j = -2; j < 2; ++j)
                    Assert.AreEqual(cosine, IVSMath.Cosine(values[i] + 2 * j * Math.PI), precision);    // cos(1.5) = cos(1.5 + 2jPI)
            }
        }

        /*
         * Tests IVSMath.Tangent method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        public void Tangent_Calculation_Integers_ReturnsTrue()
        {
            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(0, IVSMath.Tangent(i * Math.PI), precision);        // tan(iPI) = 0

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(1, IVSMath.Cosine((Math.PI / 4) + i * Math.PI), precision);        // tan(PI/4 + iPI) = 1

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(-1, IVSMath.Cosine(-(Math.PI / 4) + i * Math.PI), precision);          // tan(-PI/4 + iPI) = -1
        }

        /*
         * Tests IVSMath.Tngent method
         * Inputs decimal numbers, expects decimal number as a result
         * Return true if OK
         */
        [TestMethod]
        public void Tangent_Calculation_DecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(1.5574077, IVSMath.Tangent(1), precision);
            Assert.AreEqual(-2.1850398, IVSMath.Tangent(2), precision);
            Assert.AreEqual(1.1578212, IVSMath.Tangent(4), precision);
            Assert.AreEqual(-3.380515, IVSMath.Tangent(5), precision);

            Assert.AreEqual(0.2553419, IVSMath.Tangent(0.25), precision);
            Assert.AreEqual(80.712762, IVSMath.Tangent(4.7), precision);
        }

        /*
         * Tests IVSMath.Tangent method
         * Inputs decimal numbers, tests periodicity of values
         * Return true if OK
         */
        [TestMethod]
        public void Tangent_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            double tangent = 0.0;

            for (int i = 0; i < 5; ++i)
            {
                tangent = IVSMath.Tangent(values[i]);
                for (int j = -2; j < 2; ++j)
                    Assert.AreEqual(tangent, IVSMath.Tangent(values[i] + j * Math.PI), precision);    // tan(1.5) = tan(1.5 + jPI)
            }
        }
    }
}
