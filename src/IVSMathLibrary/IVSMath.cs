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
            if (base_ == 0)
                throw new DivideByZeroException("Division by zero");
            double result = base_;

            if (exponent == 0)
            {
                result = 1;
                //Pozor na 0 na 0.
            }
            else if(exponent > 0)
                for (int i = 1; i < exponent; i++)
                {
                    if (Math.Abs(result) > Math.Abs(double.MaxValue / base_))
                        throw new OverflowException("Value of the product is too high or too low");
                    result *= base_;
                }
            else if (exponent < 0)
                for(int i = 1; i < exponent; i++)
                {
                    if (Math.Abs(result) > Math.Abs(double.MaxValue / base_))
                        throw new OverflowException("Value of the product is too high or too low");
                    result /= base_;
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
