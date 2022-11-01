using System;

namespace UsBilgisi
{
    public class Calculator
    {
        public double Calculate(double baseNumber,double powNumber)
        {
            return Math.Pow(baseNumber, powNumber);
        }

        public double CalculatePow(double baseNumber, double powNumber)
        {
            double result = 1;
            for (int i = 0; i < powNumber; i++) 
                result = result * baseNumber; 
            return result;
        }
    }
}
