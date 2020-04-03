using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary
{
    public class IVSMath
    {
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

        public static int Factorial(int a)
        {
            return 0;
        }

        public static double Inverse(double a)
        {
            return 0;
        }

        public static double Sine(double a)
        {
            return 0;
        }

        public static double Cosine(double a)
        {
            return 0;
        }

        public static double Tangent(double a)
        {
            return 0;
        }
    }
}
