using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary
{
    public class IVSMath
    {
        /**
         * Returns sum of two parametrs
         * Throws OverflowException if the sum of two parametrs is bigger then double.MaxValue or lower than double.MinValue
         * @param   Augend  First number to add
         * @param   Addend  Second number to add
         * @return  Sum     Sum of two arguments
         */
        public static double Add(double augend, double addend)
        {
            if (addend > 0 && augend > double.MaxValue - addend)                        // if sum gets higher than double.MaxValue
                throw new OverflowException("The sum is too high.");
            if (addend < 0 && augend < double.MinValue - addend)                        // if sum gets lower than double.MinValue
                throw new OverflowException("The sum is too low.");

            double sum = checked(augend + addend);
            return sum;
        }

        /**
         * Returns difference of two parametrs
         * Throws OverflowException if the difference of two parametrs is lower then double.MinValue or higher than double.MaxValue
         * @param   Minuend     The number that is to be subtracted from.
         * @param   Subtrahend  The number that is to be subtracted.
         * @return  Difference  Difference of two parametrs
         */
        public static double Substract(double minuend, double subtrahend)
        {
            if (subtrahend > 0 && minuend < double.MinValue + subtrahend)               // if difference si lower than double.MinValue 
                throw new System.OverflowException("The difference is too low");
            if (subtrahend < 0 && minuend > double.MaxValue + subtrahend)
                throw new System.OverflowException("The difference is too high");       // if difference is higher than double.MaxValue

            double difference = checked(minuend - subtrahend);
            return difference;
        }

        /**
         * Returns product of the two given numbers (multiplier and multiplicand)
         * Throws OverflowException if the product is too high or too low
         * @param   multiplier      A number that multiplies the other number
         * @param   multiplicand    The other number
         * @return  product         Returns multiplier x multiplicand
         */
        public static double Multiply(double multiplier, double multiplicand)
        {
            if (Math.Abs(multiplier) > Math.Abs(double.MaxValue / multiplicand))
                throw new OverflowException("Value of the product is too high or too low");

            double product = multiplier * multiplicand;
            return product;
        }

        /**
         * Returns quotient of the two given numbers (dividend and divisor)
         * Throws OverflowException if the quotient is too high or too low??????????????????????????????????????????
         * @param   dividend    Number that is being seperated by the other number
         * @param   divisor     The other number
         * @return  product     Returns dividend / divisor
         */
        public static double Divide(double dividend, double divisor)
        {
            if (divisor == 0)       // if there is division by zero
                throw new DivideByZeroException("Division by zero");
            if (Math.Abs(dividend) > Math.Abs(double.MaxValue * divisor))       // if absolute value of quotient is bigger than double.MaxValue
                throw new OverflowException("Value of the quotient is too high or too low");

            double quotient = checked(dividend / divisor);
            return quotient;
        }

        public static double Root(double radicand, double degree)
        {
            return 0;
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
