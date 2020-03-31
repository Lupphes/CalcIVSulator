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

        public static double Power(double base_, int exponent)
        {
            return 0;
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
