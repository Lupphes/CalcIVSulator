using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Copyright
/// 
/// @copyright
/// CalcIVSulator (Simple calculator with GUI and mathematical library)
/// Copyright © 2020 Viktor Rucký, Ondřej Sloup, Vojtěch Vlach
/// This file is part of CalcIVSulator.
/// CalcIVSulator is free software: you can redistribute it and/or modify
/// it under the terms of the GNU General Public License as published by
/// the Free Software Foundation, either version 3 of the License, or
/// (at your option) any later version.
/// CalcIVSulator is distributed in the hope that it will be useful,
/// but WITHOUT ANY WARRANTY; without even the implied warranty of
/// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
/// GNU General Public License for more details.
/// You should have received a copy of the GNU General Public License
/// along with CalcIVSulator.  If not, see <https://www.gnu.org/licenses/>.
///
#endregion

/// @brief 
/// Mathematical library consists of these functions: Add, Subtract, Multiply, Divide, Root, Power, Factorial, Inverse, Sine, Cosine, Tangent
/// 
namespace IVSMathLibrary {
    /// @brief 
    /// All written functions of IVSMath library
    /// 
    public class IVSMath
    {
        /// @brief Precision of the math operations.
        private static readonly double precision = 0.0000000001;

        /// @brief 
        /// Returns sum of two parameters. 
        /// Throws OverflowException if the sum of two parameters is bigger then double.MaxValue or lower than double.MinValue
        /// 
        /// @throw OverflowException Thrown when sum overflows the type double
        /// @param[in] augend - First number to add
        /// @param[in] addend - Second number to add
        /// @return Sum of two arguments
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
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

        /// @brief 
        /// Returns difference of two parameters.
        /// Throws OverflowException if the difference of two parameters is lower then double.MinValue or higher than double.MaxValue
        /// 
        /// @throw OverflowException Thrown when difference overflows the type double
        /// @param[in] minuend - The number that is to be subtracted from.
        /// @param[in] subtrahend - The number that is to be subtracted.
        /// @return Difference of two parameters
        ///
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
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

        /// @brief 
        /// Returns product of the two given numbers.
        /// Throws OverflowException if the product is too high or too low.
        /// 
        /// @throw OverflowException Thrown when product overflows the type double
        /// @param[in] multiplier - A number that multiplies the other number
        /// @param[in] multiplicand - The other number
        /// @return Returns multiplier x multiplicand
        ///
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
        public static double Multiply(double multiplier, double multiplicand)
        {
            double product;
            
            if(double.IsInfinity(product = multiplier * multiplicand))
                throw new OverflowException("Value of the product is too high or too low");
            
            return product;
        }

        /// @brief 
        /// Returns quotient of the two given numbers
        /// Throws OverflowException if the quotient is too high
        /// 
        /// @throw OverflowException Thrown when quotient overflows the type double
        /// @throw DivideByZeroException Thrown when divisor (second argument) is zero
        /// @param[in] dividend - Number that is being separated by the other number
        /// @param[in] divisor - The other number
        /// @return Returns dividend / divisor
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
        public static double Divide(double dividend, double divisor)
        {
            double quotient;

            if (divisor == 0)       // if there is division by zero
                throw new DivideByZeroException("Division by zero");
            if (double.IsInfinity(quotient = dividend / divisor))
                throw new OverflowException("OverFlow Exception!");

            return quotient;
        }

        /// @brief 
        /// Calculates the Nth root of given number.
        /// 
        /// @param[in] radicant - Number which is having its square Nth root taken.
        /// @param[in] degree - The value of N.
        /// @throw ArithmeticException Thrown when radicant is negative and degree even at the same time.
        /// @throw ArithmeticException Thrown when degree is zero which cannot be processed.
        /// @return If the function is successful, it returns value of Nth root.
        ///  
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
        public static double Root(double radicand, int degree) {
            if (radicand < 0 && degree % 2 == 0) {
                throw new ArithmeticException("Radicant cannot be negative and degree even at the same time.");
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

        /// @brief 
        /// Returns a specified number raised to the specified power
        /// Throws Exception if the result is about to overflow, there is division by zero, or base_ = exponent = 0
        /// 
        /// @throw ArithmeticException Thrown when there is 0^0 operation which is not allowed
        /// @throw DivideByZeroException Thrown when exponent is negative and base is zero which is not allowed operation
        /// @param[in] base_ - A number to be raised
        /// @param[in] exponent - A number that specifies a power
        /// @param[in] ignoreInfinity - Specifies if method should ignore infinity or not. False by default
        /// @return A number raised to a specified power
        ///  
        /// @date 11.07.2020
        /// @author Vojta Vlach
        /// 
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

        /// @brief 
        /// Calculates the factorial of a given non-negative whole number.
        /// Note: returns a double, so not all digits are computed after a certain threshold.
        /// 
        /// @throw ArithmeticException The given number is outside the domain of the factorial function.
        /// @throw OverflowException The resulting factorial is too large to be stored by a double.
        /// @param[in] a - The number to calculate the factorial of
        /// @return The factorial of the given number
        /// 
        /// @date 11.07.2020
        /// @author Vojta Vlach
        /// 
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

        /// @brief 
        /// Calculates the Inverse of given number.
        /// 
        /// @param[in] base_ Number which is inversed
        /// @throw DivideByZeroException Given number cannot be zero.
        /// @throw OverflowException When the number is too high/low
        /// @return If the function is successful, it returns inversed number.
        /// 
        /// @date 11.07.2020
        /// @author Ondřej Sloup
        /// 
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

        /// @brief 
        /// Calculates the sine of a given angle in RADIANS.
        /// 
        /// @param[in] a - The angle to calculate the sine of
        /// @return The sine of the angle 'a'
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
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

        /// @brief 
        /// Calculates the cosine of a given angle in RADIANS.
        /// 
        /// @param[in] a - The angle to calculate the cosine of
        /// @return The cosine of the given angle
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
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

        /// @brief 
        /// Checks whether a given angle (in RADIANS) is valid for the tangent function.
        /// 
        /// @param[in] a - The angle to check the validity in the tangent function of
        /// @return Whether the given angle is valid for the tangent function
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
        private static bool IsValidTanAngle(double a)
        {
            a = Math.Abs(a);
            return ((a % (Math.PI / 2)) < 1e-70) && (Math.Round(a / (Math.PI / 2)) % 2 == 1); //Being as close as 1e-66-ish can still return a valid tangent.
        }

        /// @brief 
        /// Calculates the tangent of a given angle in RADIANS.
        /// 
        /// @param[in] a - The angle to compute the tangent of
        /// @throw ArithmeticException The specified angle is invalid.
        /// @throw OverflowException The result is too large to be stored by a double
        /// @return The tangent of the given angle
        /// 
        /// @date 11.07.2020
        /// @author Viktor Rucký
        /// 
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