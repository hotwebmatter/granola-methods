using System;
using static System.Console;

namespace granola_methods
{
    class Program
    {
        // class-level constants
        const double BARS_PER_CASE = 12,
                     COST_PER_CASE = 5,
                     STUDENT_GOVT_PERCENTAGE = .1;
        // class-level static variables
        static double casesSold,
                      pricePerBar,
                      grossReceipts,
                      wholesaleCost,
                      netProfits,
                      studentGovtFee,
                      profitAfterFee;
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
        }
    }
}
