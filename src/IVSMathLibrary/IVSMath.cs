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
        /// <exception cref="OverflowException">Thrown when sum overflows the type double</exception>
        /// <param name="augend">First number to add</param>
        /// <param name="addend">Second number to add</param>
        /// <returns>Sum of two arguments</returns>
        public static double Add(double augend, double addend)
        {
            try
            {
                double sum = augend + addend;

                if (sum >= double.MaxValue || sum <= double.MinValue)
                    throw new OverflowException();

                return sum;
            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow Exception!");
            }
        }

        /// <summary>
        /// Returns difference of two parametrs.
        /// Throws OverflowException if the difference of two parametrs is lower then double.MinValue or higher than double.MaxValue
        /// </summary>
        /// <exception cref="OverflowException">Thrown when difference overflows the type double</exception>
        /// <param name="minuend">The number that is to be subtracted from.</param>
        /// <param name="subtrahend">The number that is to be subtracted.</param>
        /// <returns>Difference of two parametrs</returns>
        public static double Substract(double minuend, double subtrahend)
        {
            try
            {
                double difference = minuend - subtrahend;

                if (difference >= double.MaxValue || difference <= double.MinValue)
                    throw new OverflowException("Overflow Exception!");

                return difference;
            }
            catch (OverflowException)
            {
                throw new OverflowException("Overflow Exception!");
            }
        }

        /// <summary>
        /// Returns product of the two given numbers.
        /// Throws OverflowException if the product is too high or too low.
        /// </summary>
        /// <exception cref="OverflowException">Thrown when product overflows the type double</exception>
        /// <param name="multiplier">A number that multiplies the other number</param>
        /// <param name="multiplicand">The other number</param>
        /// <returns>Returns multiplier x multiplicand</returns>
        public static double Multiply(double multiplier, double multiplicand)
        {
            double product;
            
            if(double.IsInfinity(product = multiplier * multiplicand))
                throw new OverflowException("Value of the product is too high or too low");
            
            return product;
        }

        /// <summary>
        /// Returns quotient of the two given numbers
        /// Throws OverflowException if the quotient is too high
        /// </summary>
        /// <exception cref="OverflowException">Thrown when quotient overflows the type double</exception>
        /// <exception cref="DivideByZeroException">Thrown when divisor (second argument) is zero</exception>
        /// <param name="dividend">Number that is being seperated by the other number</param>
        /// <param name="divisor">The other number</param>
        /// <returns>Returns dividend / divisor</returns>
        public static double Divide(double dividend, double divisor)
        {
            double quotient;

            if (divisor == 0)       // if there is division by zero
                throw new DivideByZeroException("Division by zero");
            if (double.IsInfinity(quotient = dividend / divisor))
                throw new OverflowException("OverFlow Exception!");

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
