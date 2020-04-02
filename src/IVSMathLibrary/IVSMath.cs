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

        public static double Root(double radicand, int degree)
        {
            if (radicand < 0 && degree % 2 == 0) {
                throw new ArithmeticException("Root cannot be negative and even.");
            }
            else if (degree == 0) {
                throw new ArithmeticException("Cannot root on 0 degree.");
            }
            else
            {
                if (radicand == 0) {
                    return 0;
                }
                if (degree == 1)
                    return radicand;
                double radicand_n;
                double value = 0.0000001f;
                double previous = double.NaN;
                do {
                    radicand_n = (radicand / Power(value, degree - 1) - value) / degree;
                    value = value + radicand_n;
                    if (previous == radicand_n) {
                        break;
                    }
                    previous = radicand_n;
                } while (Absolute(radicand_n) > 0);
                return value;
            }
        }

        private static double Absolute(double x) {
            if (x < 0)
                return -x;
            return x;
        }

        public static double Power(double base_, int exponent)
        {
            return 0;
        }

        public static int Factorial(int a)
        {
            return 0;
        }

        public static double Inverse(double a)
        {
            try {
                if (a == 0) {
                    throw new DivideByZeroException("Divided by zero!");
                }
                return (1 / a);
            }
            catch (OverflowException) {
                throw new OverflowException("Overflow exception");
            } 
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
