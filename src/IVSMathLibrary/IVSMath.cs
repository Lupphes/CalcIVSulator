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

        /// <summary>
        /// Calculates the Nth root of given number.
        /// </summary>
        /// <param name="radicand">Number which is having its square Nth root taken.</param>
        /// <param name="degree">The value of N.</param>
        /// <returns>If the function is successful, it returns value of Nth root.</returns>
        public static double Root(double radicand, int degree) {
            if (radicand < 0 && degree % 2 == 0) {
                throw new ArithmeticException("Root cannot be negative and even.");
            }
            else if (degree == 0) {
                throw new ArithmeticException("Cannot root on 0 degree.");
            }
            else {
                double radicand_n, dx;
                double precision = 0.00000000001;
                if (radicand == 0) {
                    return 0;
                }
                else if (radicand == 1 || radicand == -1)
                    return radicand;
                radicand_n = radicand * 0.5;
                dx = (radicand / Power(radicand_n, degree - 1, true) - radicand_n) / degree;
                while (dx >= precision || dx <= -precision) {
                    radicand_n = radicand_n + dx;
                    dx = (radicand / Power(radicand_n, degree - 1, true) - radicand_n) / degree;
                }
                return radicand_n;
            }
        }

        public static double Power(double base_, int exponent, bool ignoreInfinity = false)
        {
            return 0;
        }

        public static int Factorial(int a)
        {
            return 0;
        }

        /// <summary>
        /// Calculates the Inverse of given number.
        /// </summary>
        /// <param name="base_">Number which is inversed</param>
        /// <returns>If the function is successful, it returns inversed number.</returns>
        public static double Inverse(double base_) {
            try {
                if (base_ == 0) {
                    throw new DivideByZeroException("Divided by zero!");
                }
                return (1 / base_);
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
