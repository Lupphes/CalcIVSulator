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

        public static double Root(double radicand, int degree) {
            if (radicand == 0) {
                return 0;
            }
            else {
                if (radicand < 0 && degree % 2 == 0) {
                    throw new System.ArithmeticException("Root cannot be negative and even.");
                }
                if (degree == 1)
                    return radicand;
                double radicand_n;
                double precision = 0.0000001f;
                do
                {
                    radicand_n = (radicand / Power(precision, degree - 1) - precision) / degree;
                    precision = precision + radicand_n;
                } while (Absolute(radicand_n) > 0);
                return precision;
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

        public static double ToNegativeOnePower(double base_)
        {
            try {
                return (1 / base_);
            }
            catch (DivideByZeroException) {
                throw new System.DivideByZeroException("Divided by zero!");
            }            
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
