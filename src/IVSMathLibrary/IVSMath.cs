using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IVSMathLibrary
{
    public class IVSMath
    {
        /// <summary>
        /// Returns sum of two parametrs. 
        /// Throws OverflowException if the sum of two parametrs is bigger then double.MaxValue or lower than double.MinValue
        /// </summary>
        /// <param name="augend">First number to add</param>
        /// <param name="addend">Second number to add</param>
        /// <returns>Sum of two arguments</returns>
        public static double Add(double augend, double addend)
        {
            if (addend > 0 && augend > double.MaxValue - addend)        // if sum gets higher than double.MaxValue
                throw new OverflowException("The sum is too high.");
            if (addend < 0 && augend < double.MinValue - addend)        // if sum gets lower than double.MinValue
                throw new OverflowException("The sum is too low.");

            double sum = checked(augend + addend);
            return sum;
        }

        /// <summary>
        /// Returns difference of two parametrs.
        /// Throws OverflowException if the difference of two parametrs is lower then double.MinValue or higher than double.MaxValue
        /// </summary>
        /// <param name="minuend">The number that is to be subtracted from.</param>
        /// <param name="subtrahend">The number that is to be subtracted.</param>
        /// <returns>Difference of two parametrs</returns>
        public static double Substract(double minuend, double subtrahend)
        {
            if (subtrahend > 0 && minuend < double.MinValue + subtrahend)               // if difference si lower than double.MinValue 
                throw new System.OverflowException("The difference is too low");
            if (subtrahend < 0 && minuend > double.MaxValue + subtrahend)
                throw new System.OverflowException("The difference is too high");       // if difference is higher than double.MaxValue

            double difference = checked(minuend - subtrahend);
            return difference;
        }

        /// <summary>
        /// Returns product of the two given numbers.
        /// Throws OverflowException if the product is too high or too low.
        /// </summary>
        /// <param name="multiplier">A number that multiplies the other number</param>
        /// <param name="multiplicand">The other number</param>
        /// <returns>Returns multiplier x multiplicand</returns>
        public static double Multiply(double multiplier, double multiplicand)
        {
            if (Math.Abs(multiplier) > Math.Abs(double.MaxValue / multiplicand))
                throw new OverflowException("Value of the product is too high or too low");

            double product = multiplier * multiplicand;
            return product;
        }
        
        /// <summary>
        /// Returns quotient of the two given numbers
        /// Throws OverflowException if the quotient is too high
        /// </summary>
        /// <param name="dividend">Number that is being seperated by the other number</param>
        /// <param name="divisor">The other number</param>
        /// <returns>Returns dividend / divisor</returns>
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
