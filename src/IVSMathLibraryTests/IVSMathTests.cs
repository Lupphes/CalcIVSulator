#region Copyright
// <copyright file="IVSMathTests.cs" company="Lidé u výtahu">
// CalcIVSulator (Simple calculator with GUI and mathematical library)
// Copyright © 2020 Viktor Rucký, Ondřej Sloup, Vojtěch Vlach
// 
// This file is part of CalcIVSulator.
// 
// CalcIVSulator is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// CalcIVSulator is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// 
// You should have received a copy of the GNU General Public License
// along with CalcIVSulator.  If not, see <https://www.gnu.org/licenses/>.
// </copyright>
#endregion

using System;
using IVSMathLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IVSMathLibraryTests
{
    [TestClass]
    public class IVSMathTests
    {
        // Prepare
        readonly double precision = 0.0000001f;

        [TestMethod]
        [Timeout(2000)]
        public void NumberValidation_OverflowAdd_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Add(double.MaxValue, 1));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Add(double.MinValue, -1));
        }

        [TestMethod]
        [Timeout(2000)]
        public void NumberValidation_OverflowSubstract_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Substract(double.MaxValue, -5));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Substract(double.MinValue, 5));
        }
      
        [TestMethod]
        [Timeout(2000)]
        public void NumberValidation_OverflowMultiply_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Multiply(double.MaxValue, 2));
        }
      
        [TestMethod]
        [Timeout(2000)]
        public void NumberValidation_OverflowDivide_ReturnExeptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Divide(double.MaxValue, 0.5));
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationZero_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Add(0, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(10, IVSMath.Add(5, 5), 0);
            Assert.AreEqual(5, IVSMath.Add(0, 5), 0);
            Assert.AreEqual(5, IVSMath.Add(5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationNegativeWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(-10, IVSMath.Add(-5, -5), 0);
            Assert.AreEqual(-5, IVSMath.Add(0, -5), 0);
            Assert.AreEqual(-5, IVSMath.Add(-5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(11.1, IVSMath.Add(5.5, 5.6), 0);
            Assert.AreEqual(5.4, IVSMath.Add(0, 5.4), 0);
            Assert.AreEqual(5.6, IVSMath.Add(5.6, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationNegativeDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-11, IVSMath.Add(-5.9, -5.1), 0);
            Assert.AreEqual(-5.9, IVSMath.Add(0, -5.9), 0);
            Assert.AreEqual(-5.2, IVSMath.Add(-5.2, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Add_CalculationIrrationalNumbers_ReturnEqual()
        {
            Assert.AreEqual(2 * Math.PI, IVSMath.Add(Math.PI, Math.PI), precision);
            Assert.AreEqual(0, IVSMath.Add(Math.PI, -Math.PI), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationZero_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Substract(0, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationWholeNumbers_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Substract(5, 5), 0);
            Assert.AreEqual(-5, IVSMath.Substract(0, 5), 0);
            Assert.AreEqual(5, IVSMath.Substract(5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationNegativeWholeNumbers_ReturnEqual() {
            Assert.AreEqual(0, IVSMath.Substract(-5, -5), 0);
            Assert.AreEqual(10, IVSMath.Substract(5, -5), 0);
            Assert.AreEqual(5, IVSMath.Substract(0, -5), 0);
            Assert.AreEqual(-5, IVSMath.Substract(-5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-0.1, IVSMath.Substract(5.5, 5.6), precision);
            Assert.AreEqual(-5.4, IVSMath.Substract(0, 5.4), 0);
            Assert.AreEqual(5.6, IVSMath.Substract(5.6, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationNegativeDecimalNumbers_ReturnEqual()
        {
            Assert.AreEqual(-0.8, IVSMath.Substract(-5.9, -5.1), precision);
            Assert.AreEqual(5.9, IVSMath.Substract(0, -5.9));
            Assert.AreEqual(-5.2, IVSMath.Substract(-5.2, 0));
        }

        [TestMethod]
        [Timeout(2000)]
        public void Substract_CalculationIrrationalNumbers_ReturnEqual()
        {
            Assert.AreEqual(0, IVSMath.Substract(Math.PI, Math.PI), 0);
            Assert.AreEqual(2 * Math.PI, IVSMath.Substract(Math.PI, -Math.PI), precision);
            Assert.AreEqual(-2 * Math.PI, IVSMath.Substract(-Math.PI, Math.PI), precision);
            Assert.AreEqual(0, IVSMath.Substract(-Math.PI, -Math.PI), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationZero_ReturnTrue()
        {
            Assert.AreEqual(0, IVSMath.Multiply(0, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(25, IVSMath.Multiply(5, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationNegativeWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(25, IVSMath.Multiply(-5, -5), 0);
            Assert.AreEqual(-25, IVSMath.Multiply(5, -5), 0);
            Assert.AreEqual(-25, IVSMath.Multiply(-5, 5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, -5), 0);
            Assert.AreEqual(0, IVSMath.Multiply(-5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(30.8, IVSMath.Multiply(5.5, 5.6), precision);
            Assert.AreEqual(0, IVSMath.Multiply(0, 5.4), 0);
            Assert.AreEqual(0, IVSMath.Multiply(5.6, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationNegativeDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(30.09, IVSMath.Multiply(-5.9, -5.1), 0);
            Assert.AreEqual(0, IVSMath.Multiply(0, -5.9), 0);
            Assert.AreEqual(0, IVSMath.Multiply(-5.2, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Multiply_CalculationIrrationalNumbers_ReturnTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Multiply(Math.PI, Math.PI), precision);
            Assert.AreEqual(Math.PI * -Math.PI, IVSMath.Multiply(Math.PI, -Math.PI), precision);
            Assert.AreEqual(-Math.PI * Math.PI, IVSMath.Multiply(-Math.PI, Math.PI), precision);
            Assert.AreEqual(-Math.PI * -Math.PI, IVSMath.Multiply(-Math.PI, -Math.PI), precision);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_ByZero_ReturnExeptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Divide(10, 0));
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_CalculationWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(5, 5), 0);
            Assert.AreEqual(0, IVSMath.Divide(0, 5), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_CalculationNegativeWholeNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(-5, -5), 0);
            Assert.AreEqual(-1, IVSMath.Divide(5, -5), 0);
            Assert.AreEqual(0, IVSMath.Divide(0, -5), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_CalculationDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(2, IVSMath.Divide(8.6, 4.3), precision);
            Assert.AreEqual(0, IVSMath.Divide(0, 5.4), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_CalculationNegativeDecimalNumbers_ReturnTrue()
        {
            Assert.AreEqual(129, IVSMath.Divide(-25.8, -0.2), precision);
            Assert.AreEqual(0, IVSMath.Divide(0, -5.9), 0);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Divide_CalculationIrrationalNumbers_ReturnTrue()
        {
            Assert.AreEqual(1, IVSMath.Divide(Math.PI, Math.PI));
            Assert.AreEqual(-1, IVSMath.Divide(Math.PI, -Math.PI));
            Assert.AreEqual(-1, IVSMath.Divide(-Math.PI, Math.PI));
            Assert.AreEqual(1, IVSMath.Divide(-Math.PI, -Math.PI));
        }

        [TestMethod]
        [Timeout(2000)]
        public void NumberValidation_OverflowPower_ReturnExeption()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Power(double.MaxValue, 5));
        }

        [TestMethod]
        [Timeout(2000)]
        public void Power_CalculationWholeNumbers_ReturnsTrue()
        {
            Assert.AreEqual(8, IVSMath.Power(2, 3), 0);
            Assert.AreEqual(0, IVSMath.Power(0, 5), 0);
            Assert.AreEqual(1, IVSMath.Power(5, 0), 0);
        }

        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Power_ArithmeticExceptionNegative_ReturnExeptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Power(0, -5));
        }

        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Power_CalculationDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power(2.5, 2), precision);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Power_CalculationNegativeDecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power(2.5, -2), precision);
            Assert.AreEqual((25.0 / 4.0), IVSMath.Power((-2.5), 2), precision);
            Assert.AreEqual((4.0 / 25.0), IVSMath.Power((-2.5), -2), precision);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Power_CalculationIrrationalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(Math.PI * Math.PI, IVSMath.Power(Math.PI, 2), precision);
        }

        [TestMethod]
        [Timeout(2000)]
        public void Root_Square_RadicandIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(2, IVSMath.Root(4, 2), precision);
            Assert.AreEqual(4, IVSMath.Root(16, 2), precision);
            Assert.AreEqual(2, IVSMath.Root(2, 2) * IVSMath.Root(2, 2), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_Square_RadicandRealPositive_ReturnsTrue()
        {
            Assert.AreEqual(3.141592, IVSMath.Root(3.141592, 2) * IVSMath.Root(3.141592, 2), precision);
            Assert.AreEqual(0.5, IVSMath.Root(0.5, 2) * IVSMath.Root(0.5, 2), precision);
            Assert.AreEqual(138.6576, IVSMath.Root(138.6576, 2) * IVSMath.Root(138.6576, 2), precision);
        }
        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Root_Square_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 2), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_Square_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 2), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_Cube_RadicandIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(3, IVSMath.Root(27, 3), precision);
            Assert.AreEqual(4, IVSMath.Root(64, 3), precision);
            double root = IVSMath.Root(3, 3);
            Assert.AreEqual(3, root * root * root, precision);
        }
        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
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
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Root_Cube_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 3), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_Cube_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 3), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_Cube_RadicandNegativeOne_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Root(-1, 3), 0);
        }
        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandPositive_ReturnsTrue()
        {
            double radicand, root, acc;
            int degree;
            radicand = 3154653;
            degree = 17;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, 0.001); //MSTest doesn't do significant-figures comparing; it does absolute. So we need to use a "lower" precision here.

            radicand = 200848720;
            degree = 88;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, 0.001); //MSTest doesn't do significant-figures comparing; it does absolute. So we need to use a "lower" precision here.

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
        [Timeout(2000)]
        public void Root_VariousNegativeDegrees_RadicandPositive_ReturnsTrue()
        {
            Assert.AreEqual(0.41467583676069403267262148780124258521006412984280585832, IVSMath.Root(3154653, -17), precision);
            Assert.AreEqual(0.81418263973475159728608571723709230293818205431942732878, IVSMath.Root(200848720, -93), precision);
            Assert.AreEqual(0.84913863735898463196507840017453185257217361063386017151, IVSMath.Root(3.141592, -7), precision);
            Assert.AreEqual(1.120572042801258390814818630883392608801637382192571644905, IVSMath.Root(0.56598, -5), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandNegativeInvalid_ReturnsExceptions()
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
        [Timeout(2000)]
        public void Root_VariousNegativeDegrees_RadicandNegativeInvalid_ReturnsExceptions()
        {
            try
            {
                IVSMath.Root(-131, -16);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-1, -106);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(-3.14649871, -1162);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandNegativeValid_ReturnsTrue()
        {
            double radicand, root, acc;
            int degree;
            radicand = -3154653;
            degree = 17;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, 0.001); //MSTest doesn't do significant-figures comparing; it does absolute. So we need to use a "lower" precision here.

            radicand = -200848720;
            degree = 93;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, 0.001); //MSTest doesn't do significant-figures comparing; it does absolute. So we need to use a "lower" precision here.

            radicand = -3.141592;
            degree = 7;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);

            radicand = -0.56598;
            degree = 5;
            root = IVSMath.Root(radicand, degree);
            acc = 1;
            for (int i = 0; i < degree; i++)
                acc *= root;
            Assert.AreEqual(radicand, acc, precision);
        }
        public void Root_VariousNegativeDegrees_RadicandNegativeValid_ReturnsTrue()
        {           
            Assert.AreEqual(-0.41467583676069403267262148780124258521006412984280585832, IVSMath.Root(-3154653,-17), precision);
            Assert.AreEqual(-0.81418263973475159728608571723709230293818205431942732878, IVSMath.Root(-200848720, -93), precision);
            Assert.AreEqual(-0.84913863735898463196507840017453185257217361063386017151, IVSMath.Root(-3.141592, -7), precision);
            Assert.AreEqual(-1.12057204280125839081481863088339260880163738219257164490, IVSMath.Root(-0.56598, -5), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandZero_ReturnsTrue()
        {
            Assert.AreEqual(0, IVSMath.Root(0, 13), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 136), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 1987), 0);
            Assert.AreEqual(0, IVSMath.Root(0, 241628), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousNegativeDegrees_RadicandZero_ReturnsExceptions()
        {
            try {
                IVSMath.Root(0, -13);
                Assert.Fail();
            }
            catch(Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(0, -136);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(0, -1987);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Root(0, -241628);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, 13), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 136), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 1987), 0);
            Assert.AreEqual(1, IVSMath.Root(1, 241628), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousNegativeDegrees_RadicandOne_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Root(1, -13), 0);
            Assert.AreEqual(1, IVSMath.Root(1, -136), 0);
            Assert.AreEqual(1, IVSMath.Root(1, -1987), 0);
            Assert.AreEqual(1, IVSMath.Root(1, -241628), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousPositiveDegrees_RadicandNegativeOne_Valid_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Root(-1, 13), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 135), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 1987), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, 241627), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Root_VariousNegativeDegrees_RadicandNegativeOne_Valid_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Root(-1, -13), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, -135), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, -1987), 0);
            Assert.AreEqual(-1, IVSMath.Root(-1, -241627), 0);
        }
        [TestMethod]
        [Timeout(2000)]
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
        

        public void Inverse_CalculationOnePositive_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Inverse(1), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationOneNegative_ReturnsTrue()
        {
            Assert.AreEqual(-1, IVSMath.Inverse(-1), 0);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationZero_ReturnsExceptions()
        {
            Assert.ThrowsException<DivideByZeroException>(() => IVSMath.Inverse(0));
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationIntegerPositive_ReturnsTrue()
        {
            Assert.AreEqual(1.0 / 5.0, IVSMath.Inverse(5), precision);
            Assert.AreEqual(1.0 / 158963.0, IVSMath.Inverse(158963), precision);
            Assert.AreEqual(1.0 / 42.0, IVSMath.Inverse(42), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationRealPositiveAbsGreaterThanOne_ReturnsTrue()
        {
            Assert.AreEqual(8.0 / 41.0, IVSMath.Inverse(5.125), precision);
            Assert.AreEqual(1.0 / 158963.45892, IVSMath.Inverse(158963.45892), precision);
            Assert.AreEqual(50.0 / 2121.0, IVSMath.Inverse(42.42), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationRealPositiveAbsLessThanOne_ReturnsTrue()
        {
            Assert.AreEqual(25, IVSMath.Inverse(0.04), precision);
            Assert.AreEqual(5000.0 / 823.0, IVSMath.Inverse(0.1646), precision);
            Assert.AreEqual(50.0 / 21.0, IVSMath.Inverse(0.42), precision);
        }
        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Inverse_CalculationRealNegativeAbsLessThanOne_ReturnsTrue()
        {
            Assert.AreEqual(-25, IVSMath.Inverse(-0.04), precision);
            Assert.AreEqual(-(5000.0 / 823.0), IVSMath.Inverse(-0.1646), precision);
            Assert.AreEqual(-(50.0 / 21.0), IVSMath.Inverse(-0.42), precision);
        }
        [TestMethod]
        [Timeout(2000)]
        public void Inverse_CalculationOverflow_ReturnsExceptions()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Inverse(Double.Epsilon));
        }
        /*
         * Tests IVSMath.Sine method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
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
        [Timeout(2000)]
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
        [Timeout(2000)]
        public void Sine_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            for (int i = 0; i < 5; ++i)
            {
                double sine = IVSMath.Sine(values[i]);
                for (int j = -50; j < 50; ++j) 
                    Assert.AreEqual(sine, IVSMath.Sine(values[i] + 2 * j * Math.PI), precision);    // sin(1.5) = sin(1.5 + 2jPI)
            }
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Cosine_Calculation_Integers_ReturnsTrue()
        {
            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(0, IVSMath.Cosine((Math.PI / 2 ) + i * Math.PI), precision);       // cos(PI/2 + i*PI) = 0

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(1, IVSMath.Cosine(2 * i * Math.PI), precision);   // cos(2iPI) = 1

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(-1, IVSMath.Cosine(Math.PI + 2 * i * Math.PI), precision);     // cos(PI + 2iPI) = -1  
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs decimal numbers, expects decimal number as a result
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Cosine_Calculation_DecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(0.540302305868139717400936607442976603732310420617922227670, IVSMath.Cosine(1), precision);
            Assert.AreEqual(-0.41614683654714238699756822950076218976600077107554489075, IVSMath.Cosine(2), precision);
            Assert.AreEqual(-0.65364362086361191463916818309775038142413359664621824700, IVSMath.Cosine(4), precision);
            Assert.AreEqual(0.283662185463226264466639171513557308334422592252215944930, IVSMath.Cosine(5), precision);

            Assert.AreEqual(0.9689124, IVSMath.Cosine(0.25), precision);
            Assert.AreEqual(-0.0123887, IVSMath.Cosine(4.7), precision);
        }

        /*
         * Tests IVSMath.Cosine method
         * Inputs decimal numbers, tests periodicity of values
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Cosine_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            for (int i = 0; i < 5; ++i)
            {
                double cosine = IVSMath.Cosine(values[i]);
                for (int j = -50; j < 50; ++j)
                    Assert.AreEqual(cosine, IVSMath.Cosine(values[i] + 2 * j * Math.PI), precision);    // cos(1.5) = cos(1.5 + 2jPI)
            }
        }

        /*
         * Tests IVSMath.Tangent method
         * Inputs PI/2 and expects exception
         * Return exception
         */
        [TestMethod]
        [Timeout(2000)]
        public void Tangent_PIpulException_ReturnsException()
        {
            try
            {
                IVSMath.Tangent(Math.PI/2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Tangent(-Math.PI / 2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }

        /*
         * Tests IVSMath.Tangent method
         * Inputs only numbers so the result is integer
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Tangent_Calculation_Integers_ReturnsTrue()
        {
            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(0, IVSMath.Tangent(i * Math.PI), precision);        // tan(iPI) = 0

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(1, IVSMath.Tangent((Math.PI / 4) + i * Math.PI), precision);        // tan(PI/4 + iPI) = 1

            for (int i = -2; i < 3; ++i)
                Assert.AreEqual(-1, IVSMath.Tangent(-(Math.PI / 4) + i * Math.PI), precision);          // tan(-PI/4 + iPI) = -1
        }

        /*
         * Tests IVSMath.Tngent method
         * Inputs decimal numbers, expects decimal number as a result
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Tangent_Calculation_DecimalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(1.557407724654902230506974807458360173087250772381520038383, IVSMath.Tangent(1), precision);
            Assert.AreEqual(-2.18503986326151899164330610231368254343201774622766316456, IVSMath.Tangent(2), precision);
            Assert.AreEqual(1.157821282349577583137342418267323923119762767367142130084, IVSMath.Tangent(4), precision);
            Assert.AreEqual(-3.38051500624658563698270587944734390870956920828545987717, IVSMath.Tangent(5), precision);

            Assert.AreEqual(0.255341921221036266504482236490473678204201638800822621740, IVSMath.Tangent(0.25), precision);
            Assert.AreEqual(80.71276296747361169735821765792218589590549715980917724763, IVSMath.Tangent(4.7), precision);
        }

        /*
         * Tests IVSMath.Tangent method
         * Inputs decimal numbers, tests periodicity of values
         * Return true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Tangent_Calculation_PeriodicityTest_ReturnsTrue()
        {
            double[] values = { 1.5, 2.6, 3.82, 5.123, 8.73 };
            for (int i = 0; i < 5; ++i)
            {
                double tangent = IVSMath.Tangent(values[i]);
                for (int j = -50; j < 50; ++j)
                    Assert.AreEqual(tangent, IVSMath.Tangent(values[i] + j * Math.PI), precision);    // tan(1.5) = tan(1.5 + jPI)
            }
        }
        /**
         * Test IVSMath.Factorial method
         * Inputs natural numbers only
         * Returns true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Factorial_Calculation_NaturalNumbers_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Factorial(1), 0);
            Assert.AreEqual(2, IVSMath.Factorial(2), 0);
            Assert.AreEqual(6, IVSMath.Factorial(3), 0);
            Assert.AreEqual(24, IVSMath.Factorial(4), 0);
            Assert.AreEqual(120, IVSMath.Factorial(5), 0);
            Assert.AreEqual(479001600, IVSMath.Factorial(12), 0);
            Assert.AreEqual(7.2574156153079989673967282111292631147169916812964513E+306, IVSMath.Factorial(170), 1E+295); //MSTest doesn't do significant-figures comparing; it does absolute. So we need to use a "lower" precision here.
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs numbers so high that their factorial cannot fit into type double
         * Throws OverflowException
         */
        [TestMethod]
        [Timeout(2000)]
        public void Factorial_Calculation_Overflow_ReturnOverflowException()
        {
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(171));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(172));
            Assert.ThrowsException<OverflowException>(() => IVSMath.Factorial(200));
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs zero
         * Returns true if OK
         */
        [TestMethod]
        [Timeout(2000)]
        public void Factorial_Calculation_Zero_ReturnsTrue()
        {
            Assert.AreEqual(1, IVSMath.Factorial(0), 0);
        }

        /**
         * Test IVSMath.Factorial method
         * Inputs negative numbers
         * Throws exceptions
         */
        [TestMethod]
        [Timeout(2000)]
        public void Factorial_Calculation_NegativeNumbers_ReturnExceptions()
        {
            try
            {
                IVSMath.Factorial(-1);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-2);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-3);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
            try
            {
                IVSMath.Factorial(-15);
                Assert.Fail();
            }
            catch (Exception e)
            {
                if (e is AssertFailedException)
                    Assert.Fail();
            }
        }
    }
}
