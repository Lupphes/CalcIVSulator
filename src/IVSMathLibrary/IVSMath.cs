using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary
{
    public class IVSMath
    {
        private static readonly double precision = 0.0000000001;

        public static double Add(double augend, double addend)
        {
            return 0;
        }

        public static double Substract(double minuend, double subtrahend)
        {
            return 0;
        }

        public static double Multiply(double multiplier, double multiplicand)
        {
            return 0;
        }

        public static double Divide(double dividend, double divisor)
        {
            return 0;
        }

        public static double Root(double radicand, double degree)
        {
            return 0;
        }

        /*
         * Returns a specified number raised to the specified power
         * Throw Excpetion if the result is about to overflow, there is division by zero, or base_ = exponent = 0
         * @param   base_       A number to be raised
         * @param   exponent    A number that specifies a power
         * @return  power       A number raised to a specified power
         */
        public static double Power(double base_, int exponent)
        {
            double result = 1;
            bool negativeExponent = false;

            if (exponent == 0)
            {
                if (base_ == 0)
                    throw new Exception("0^0");
                return 1;
            }
            else if (exponent < 0)
            {
                exponent *= -1;
                negativeExponent = true;
                if (base_ == 0)
                    throw new DivideByZeroException("Division by zero");
            }

            for (int i = 0; i < exponent; i++)
            {
                if (Math.Abs(result) > Math.Abs(double.MaxValue / base_))
                    throw new OverflowException("Value of the product is too high or too low");
                result *= base_;
            }

            if (negativeExponent)
                result = 1 / result;

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

        public static double Inverse(double a)
        {
            return 0;
        }
        
        /// <summary>
        /// Calculates the sine of a given angle in RADIANS.
        /// </summary>
        /// <param name="a">The angle to calculate the sine of</param>
        /// <returns>The sine of the angle 'a'</returns>
        public static double Sine(double a)
        {
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
        private static bool isValidTanAngle(double a)
        {
            a = Math.Abs(a);
            return ((a % (Math.PI / 2)) < IVSMath.precision) && (Math.Round(a / (Math.PI / 2)) % 2 == 1);
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
            if (IVSMath.isValidTanAngle(a))
                throw new ArithmeticException();
            
            double result = IVSMath.Sine(a) / IVSMath.Cosine(a);
            
            if (Double.IsInfinity(result))
                throw new OverflowException();
            
            return result;
        }
    }
}
