using System;

namespace UsBilgisi
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            double result1 = calculator.Calculate(2, 3);
            double result2 = calculator.CalculatePow(2, 3);
            Console.WriteLine($"method1={result1} method2={result2}");
            Console.ReadKey();
        }
    }
}
