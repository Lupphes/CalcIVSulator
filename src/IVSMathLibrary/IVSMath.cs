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
