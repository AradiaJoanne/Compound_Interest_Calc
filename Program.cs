using System;

namespace CompoundInterestCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get the Principle Val
            Console.WriteLine("Enter the Principle (Initial Amount) of the Investment/Loan:");
            double P = Convert.ToDouble(Console.ReadLine());

            // Get the Annual Interest Rate
            Console.WriteLine("Enter the Annual Interest Rate:");
            double r = Convert.ToDouble(Console.ReadLine());

            // Get the amount of times compounded
            Console.WriteLine("Enter the Amount of Times in a Year the Interest is Compounded: ");
            Console.WriteLine("* Note: For Monthly enter 12 and Yearly enter 1");
            int n = Convert.ToInt32(Console.ReadLine());

            // Get the length of invest/loan
            Console.WriteLine("Enter the Length of Time that the Money will be Invested (Years)");
            int t = Convert.ToInt32(Console.ReadLine());

            //Do Math
            double A = P * Math.Pow((1 + r / n), n * t);
            Console.WriteLine($"The total value of your investment after {t} years, including interest will be ${A}");

            Console.WriteLine("Thank you for using the Compound Interest Calculator, Press any key to exit!");
            Console.ReadKey();
        }
    }
}
