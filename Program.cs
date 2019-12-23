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
                      barsSold,
                      grossReceipts,
                      wholesaleCost,
                      netProfits,
                      studentGovtFee,
                      profitAfterFee;
        static void Main(string[] args)
        {
            casesSold = ReadDouble("Enter cases sold:");
            pricePerBar = ReadDouble("Enter price per bar:");
            CalculateProfits();
            WriteLine("****** Generating Results ******");
        }
        static double ReadDouble(string label)
        {
            Write("{0} ", label);
            double number;
            string userInput = ReadLine();
            while (Double.TryParse(userInput, out number) == false)
            {
                Write("{0}{1} ", "Invalid input!\n", label);
                userInput = ReadLine();
            }
            return number;
        }
        static void CalculateProfits()
        {
            barsSold = casesSold * BARS_PER_CASE;
            grossReceipts = barsSold * pricePerBar;
            wholesaleCost = casesSold * COST_PER_CASE;
            netProfits = grossReceipts - wholesaleCost;
            studentGovtFee = netProfits * STUDENT_GOVT_PERCENTAGE;
            profitAfterFee = netProfits - studentGovtFee;
        }
    }
}
