#region Copyright
// <copyright file="IVSMath Library" company="Lidé u výtahu">
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
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary {
    /// <summary>
    /// Mathematical library consists of these functions: Add, Substract, Multiply, Divide, Root, Power, Factorial, Inverse, Sine, Cosine, Tangent
    /// </summary>
    public class IVSMath
    {
        private static readonly double precision = 0.0000000001;

        /// <summary>
        /// Returns sum of two parametrs. 
        /// Throws OverflowException if the sum of two parametrs is bigger then double.MaxValue or lower than double.MinValue
        /// </summary>
        /// <exception cref="OverflowException">Thrown when sum overflows the type double</exception>
        /// <param name="augend">First number to add</param>
        /// <param name="addend">Second number to add</param>
        /// <returns>Sum of two arguments</returns>
        public static double Add(double augend, double addend)
        {
            try
            {
                double sum = augend + addend;

                if (sum >= double.MaxValue || sum <= double.MinValue)
                    throw new OverflowException();

                return sum;
            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow Exception!");
            }
        }

        /// <summary>
        /// Returns difference of two parametrs.
        /// Throws OverflowException if the difference of two parametrs is lower then double.MinValue or higher than double.MaxValue
        /// </summary>
        /// <exception cref="OverflowException">Thrown when difference overflows the type double</exception>
        /// <param name="minuend">The number that is to be subtracted from.</param>
        /// <param name="subtrahend">The number that is to be subtracted.</param>
        /// <returns>Difference of two parametrs</returns>
        public static double Subtract(double minuend, double subtrahend)
        {
            try
            {
                double difference = minuend - subtrahend;

                if (difference >= double.MaxValue || difference <= double.MinValue)
                    throw new OverflowException("Overflow Exception!");

                return difference;
            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow Exception!");
            }
        }

        /// <summary>
        /// Returns product of the two given numbers.
        /// Throws OverflowException if the product is too high or too low.
        /// </summary>
        /// <exception cref="OverflowException">Thrown when product overflows the type double</exception>
        /// <param name="multiplier">A number that multiplies the other number</param>
        /// <param name="multiplicand">The other number</param>
        /// <returns>Returns multiplier x multiplicand</returns>
        public static double Multiply(double multiplier, double multiplicand)
        {
            double product;
            
            if(double.IsInfinity(product = multiplier * multiplicand))
                throw new OverflowException("Value of the product is too high or too low");
            
            return product;
        }

        /// <summary>
        /// Returns quotient of the two given numbers
        /// Throws OverflowException if the quotient is too high
        /// </summary>
        /// <exception cref="OverflowException">Thrown when quotient overflows the type double</exception>
        /// <exception cref="DivideByZeroException">Thrown when divisor (second argument) is zero</exception>
        /// <param name="dividend">Number that is being seperated by the other number</param>
        /// <param name="divisor">The other number</param>
        /// <returns>Returns dividend / divisor</returns>
        public static double Divide(double dividend, double divisor)
        {
            double quotient;

            if (divisor == 0)       // if there is division by zero
                throw new DivideByZeroException("Division by zero");
            if (double.IsInfinity(quotient = dividend / divisor))
                throw new OverflowException("OverFlow Exception!");

            return quotient;
        }

        /// <summary>
        /// Calculates the Nth root of given number.
        /// </summary>
        /// <param name="radicand">Number which is having its square Nth root taken.</param>
        /// <param name="degree">The value of N.</param>
        /// <exception cref="ArithmeticException">Thrown when radicand is negative and degree even at the same time.</exception>
        /// <exception cref="ArithmeticException">Thrown when degree is zero which cannot be processed.</exception>
        /// <returns>If the function is successful, it returns value of Nth root.</returns>
        public static double Root(double radicand, int degree) {
            if (radicand < 0 && degree % 2 == 0) {
                throw new ArithmeticException("Radicand cannot be negative and degree even at the same time.");
            }
            if (radicand == 0 && degree < 0)
            {
                throw new ArithmeticException("Root of zero on negative degree is not allowed.");
            }
            else if (degree == 0) {
                throw new ArithmeticException("Cannot make a root on 0th degree.");
            }
            else {
                double radicand_n, dx;
                double precision = 0.00000000001;
                if (radicand == 0) {
                    return 0;
                }
                else if (radicand == 1 || radicand == -1)
                    return radicand;
                bool negative = false;
                if (degree < 0) {
                    negative = true;
                    degree = -degree;
                }
                radicand_n = radicand * 0.5;
                dx = (radicand / Power(radicand_n, degree - 1, true) - radicand_n) / degree;
                while (dx >= precision || dx <= -precision) {
                    radicand_n += dx;
                    dx = (radicand / Power(radicand_n, degree - 1, true) - radicand_n) / degree;
                }
                if (negative) {
                    radicand_n = Inverse(radicand_n);
                }
                return radicand_n;
            }
        }

        /// <summary>
        /// Returns a specified number raised to the specified power
        /// Throws Excpetion if the result is about to overflow, there is division by zero, or base_ = exponent = 0
        /// </summary>
        /// <exception cref="ArithmeticException">Thrown when there is 0^0 operation which is not allowed</exception>
        /// <exception cref="DivideByZeroException">Thrown when exponent is negative and base is zero which is not allowed operation</exception>
        /// <param name="base_">A number to be raised</param>
        /// <param name="exponent">A number that specifies a power</param>
        /// <param name="ignoreInfinity">Specifies if method should ignore infinity or not. False by default</param>
        /// <returns>A number raised to a specified power</returns>
        public static double Power(double base_, int exponent, bool ignoreInfinity = false)
        {
            double result = 1;
            bool negativeExponent = false;

            if (exponent == 0) {
                if (base_ == 0)
                    throw new ArithmeticException("0^0 is undefined.");
                return result;
            }
            else if (exponent < 0) {
                exponent = -exponent;
                negativeExponent = true;
                if (base_ == 0)
                    throw new DivideByZeroException("Division by zero!");
            }

            for (int i = 0; i < exponent; i++) {
                result *= base_;
                if (double.IsInfinity(result) && !ignoreInfinity)
                    throw new OverflowException("Value of the product is too high or too low!");
            }

            if (negativeExponent) {
                result = Inverse(result);
            }
            return result;
        }

        /// <summary>
        /// Calculates the factorial of a given non-negative whole number.
        /// Note: returns a double, so not all digits are computed after a certain threshold.
        /// </summary>
        /// <exception cref="ArithmeticException">The given number is outside the domain of the factorial function.</exception>
        /// <exception cref="OverflowException">The resulting factorial is too large to be stored by a double.</exception>
        /// <param name="a">The number to calculate the factorial of</param>
        /// <returns>The factorial of the given number</returns>
        public static double Factorial(int a)
        {
            if (a < 0)
                throw new ArithmeticException();
            
            double result = 1;
            for (; a > 0; a--)
                result *= a;
            
            if (Double.IsInfinity(result))
                throw new OverflowException();
            else
                return result;
        }

        /// <summary>
        /// Calculates the Inverse of given number.
        /// </summary>
        /// <param name="base_">Number which is inversed</param>
        /// <exception cref="DivideByZeroException">Given number cannot be zero.</exception>
        /// <exception cref="OverflowException">When the number is too high/low</exception>
        /// <returns>If the function is successful, it returns inversed number.</returns>
        public static double Inverse(double base_) {
            double result;
            if (base_ == 0) {
                throw new DivideByZeroException("Divided by zero!");
            }
            result = 1 / base_;
            if (Double.IsInfinity(result))
                throw new OverflowException();
            return result;
        }
        
        /// <summary>
        /// Calculates the sine of a given angle in RADIANS.
        /// </summary>
        /// <param name="a">The angle to calculate the sine of</param>
        /// <returns>The sine of the angle 'a'</returns>
        public static double Sine(double a)
        {
            a %= Math.PI * 2;
            double result = a;
            bool add = false;
            double term = 0;
            double previousTerm;
            int i = 3;
            do
            {
                previousTerm = term;
                term = IVSMath.Power(a, i) / IVSMath.Factorial(i);
                if (add)
                    result += term;
                else
                    result -= term;
                add = !add;
                i += 2;
            } while (Math.Abs(term - previousTerm) > IVSMath.precision);
            return result;
        }
     
        /// <summary>
        /// Calculates the cosine of a given angle in RADIANS.
        /// </summary>
        /// <param name="a">The angle to calculate the cosine of</param>
        /// <returns>The cosine of the given angle</returns>
        public static double Cosine(double a)
        {
            a %= Math.PI * 2;
            double result = 1;
            bool add = false;
            double term = 0;
            double previousTerm;
            int i = 2;
            do
            {
                previousTerm = term;
                term = IVSMath.Power(a, i) / IVSMath.Factorial(i);
                if (add)
                    result += term;
                else
                    result -= term;
                add = !add;
                i += 2;
            } while (Math.Abs(term - previousTerm) > IVSMath.precision);
            return result;
        }

        /// <summary>
        /// Checks whether a given angle (in RADIANS) is valid for the tangent function.
        /// </summary>
        /// <param name="a">The angle to check the validity in the tangent function of</param>
        /// <returns>Whether the given angle is valid for the tangent function</returns>
        private static bool IsValidTanAngle(double a)
        {
            a = Math.Abs(a);
            return ((a % (Math.PI / 2)) < 1e-70) && (Math.Round(a / (Math.PI / 2)) % 2 == 1); //Being as close as 1e-66-ish can still return a valid tangent.
        }

        /// <summary>
        /// Calculates the tangent of a given angle in RADIANS.
        /// </summary>
        /// <param name="a">The angle to compute the tangent of</param>
        /// <exception cref="ArithmeticException">The specified angle is invalid.</exception>
        /// <exception cref="OverflowException">The result is too large to be stored by a double</exception>
        /// <returns>The tangent of the given angle</returns>
        public static double Tangent(double a)
        {
            if (IVSMath.IsValidTanAngle(a))
                throw new ArithmeticException();
            
            double result = IVSMath.Sine(a) / IVSMath.Cosine(a);
            
            if (Double.IsInfinity(result))
                throw new OverflowException();
            
            return result;
        }
    }
}