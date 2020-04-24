using System;
using IVSMathLibrary;

namespace SampleStandartDeviation
{
    class SSDeviation
    {
        static void Main(string[] args)
        {
            string input = "";      // input from stdin (or file)
            double number = 0,      // every new number
                sum = 0,            // sum of all loaded numbers
                squaresum = 0,      // sum of loaded numbers squared
                average = 0,        // average value of a number
                SSDeviation = 0;    // sample standard deviation
            int count = 0;          // number count

            // reading all values from Console input (or file)
            while((input = Console.ReadLine()) != null)
            {
                if (double.TryParse(input, out number))     // try parse string to double, when successfull process the number
                {
                    count = (int)IVSMath.Add(count, 1.0);   // count++
                    sum = IVSMath.Add(sum, number);         // sum += number
                    squaresum = IVSMath.Add(squaresum, IVSMath.Power(number, 2));   // squaresum += number^2
                }
            }

            average = IVSMath.Divide(sum, count);       // average = sum/count
            
            double countMin1 = IVSMath.Substract(count, 1);     // countMin1 = count - 1
            double averageSq = IVSMath.Power(average, 2);       // averageSq = average^2
            double SSDeviationSq = IVSMath.Multiply(IVSMath.Divide(1, countMin1), IVSMath.Substract(squaresum, IVSMath.Multiply(count, averageSq)));    // SSDevitaionSq = (1/countMin1)*(squaresum-count*averageSq
            SSDeviation = IVSMath.Root(SSDeviationSq, 2);       // SSDeviation = SSDeviationSq^1/2
            // s = ((1/(N-1))*(squaresum-count*average^2))^1/2

            Console.WriteLine(SSDeviation);
        }
    }
}
