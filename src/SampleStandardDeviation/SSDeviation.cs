using System;
using IVSMathLibrary;

namespace SampleStandardDeviation
{
    class SSDeviation
    {
        static int N = 1;      // number of function repetition (1 is default)

        static void Main(string[] args)
        {
            string input = "";      // input from stdin (or file)
            double number = 0,      // every new number
                sum = 0,            // sum of all loaded numbers
                squaresum = 0,      // sum of loaded numbers squared
                average = 0,        // average value of a number
                SSDeviation = 0;    // sample standard deviation
            int count = 0;          // number count

            // argument handling
            if(args.Length != 0)
                if(!int.TryParse(args[0], out N))
                    N = 1;      // if conversion was not successful, use the default value

            // reading all values from Console input (or file)
            while ((input = Console.ReadLine()) != null)
            {
                if (double.TryParse(input, out number))     // try parse string to double, when successfull process the number
                {
                    count = (int)Add(count, 1.0);   // count++
                    sum = Add(sum, number);         // sum += number
                    squaresum = Add(squaresum, Power(number, 2));   // squaresum += number^2
                }
            }
            
            // calculation of sample standard deviation
            average = Divide(sum, count);       // average = sum/count

            double countMin1 = Subtract(count, 1);     // countMin1 = count - 1
            double averageSq = Power(average, 2);       // averageSq = average^2
            double SSDeviationSq = Multiply(Divide(1, countMin1), Subtract(squaresum, Multiply(count, averageSq)));
            // SSDevitaionSq = (1/countMin1)*(squaresum-count*averageSq
            SSDeviation = Root(SSDeviationSq, 2);       // SSDeviation = SSDeviationSq^1/2
            // s = ((1/(N-1))*(squaresum-count*average^2))^1/2

            Console.WriteLine(SSDeviation);
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Returns sum of two parametrs. 
        /// Throws OverflowException if the sum of two parametrs is bigger then double.MaxValue or lower than double.MinValue
        /// </summary>
        /// <exception cref="OverflowException">Thrown when sum overflows the type double</exception>
        /// <param name="augend">First number to add</param>
        /// <param name="addend">Second number to add</param>
        /// <returns>Sum of two arguments</returns>
        public static double Add(double augend, double addend)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Add(augend, addend);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Returns difference of two parametrs.
        /// Throws OverflowException if the difference of two parametrs is lower then double.MinValue or higher than double.MaxValue
        /// </summary>
        /// <exception cref="OverflowException">Thrown when difference overflows the type double</exception>
        /// <param name="minuend">The number that is to be subtracted from.</param>
        /// <param name="subtrahend">The number that is to be subtracted.</param>
        /// <returns>Difference of two parametrs</returns>
        public static double Subtract(double minuend, double subtrahend)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Subtract(minuend, subtrahend);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Returns product of the two given numbers.
        /// Throws OverflowException if the product is too high or too low.
        /// </summary>
        /// <exception cref="OverflowException">Thrown when product overflows the type double</exception>
        /// <param name="multiplier">A number that multiplies the other number</param>
        /// <param name="multiplicand">The other number</param>
        /// <returns>Returns multiplier x multiplicand</returns>
        public static double Multiply(double multiplier, double multiplicand)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Multiply(multiplier, multiplicand);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
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
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Divide(dividend, divisor);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Calculates the Nth root of given number.
        /// </summary>
        /// <param name="radicand">Number which is having its square Nth root taken.</param>
        /// <param name="degree">The value of N.</param>
        /// <exception cref="ArithmeticException">Thrown when radicand is negative and degree even at the same time.</exception>
        /// <exception cref="ArithmeticException">Thrown when degree is zero which cannot be processed.</exception>
        /// <returns>If the function is successful, it returns value of Nth root.</returns>
        public static double Root(double radicand, int degree)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Root(radicand, degree);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
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
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Power(base_, exponent, ignoreInfinity);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Calculates the factorial of a given non-negative whole number.
        /// Note: returns a double, so not all digits are computed after a certain threshold.
        /// </summary>
        /// <exception cref="ArithmeticException">The given number is outside the domain of the factorial function.</exception>
        /// <exception cref="OverflowException">The resulting factorial is too large to be stored by a double.</exception>
        /// <param name="a">The number to calculate the factorial of</param>
        /// <returns>The factorial of the given number</returns>
        public static double Factorial(int a)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Factorial(a);
            return res;
        }

        /// <summary>
        /// Calls function from IVSMath N times.
        /// Calculates the Inverse of given number.
        /// </summary>
        /// <param name="base_">Number which is inversed</param>
        /// <exception cref="DivideByZeroException">Given number cannot be zero.</exception>
        /// <exception cref="OverflowException">When the number is too high/low</exception>
        /// <returns>If the function is successful, it returns inversed number.</returns>
        public static double Inverse(double base_)
        {
            double res = 0;
            for (int i = 0; i < N; i++)
                res = IVSMath.Inverse(base_);
            return res;
        }
    }
}
