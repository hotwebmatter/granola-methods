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
            WriteLine(DisplayResults());
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
        static string DisplayResults()
        {
            string result = String.Format("\n****** Granola Bar Proceeds ******\n");
            result += String.Format("* {0, 20}{1, 10:N} *\n", "Bars Sold:", barsSold);
            result += String.Format("* {0, 20}{1, 10:C} *\n", "Gross Receipts:", grossReceipts);
            result += String.Format("* {0, 20}{1, 10:C} *\n", "Wholesale Cost:", wholesaleCost);
            result += String.Format("* {0, 20}{1, 10:C} *\n", "Net Profits", netProfits);
            result += String.Format("* {0, 20}{1, 10:C} *\n", "Student Gov't Fee:", studentGovtFee);
            result += String.Format("* {0, 20}{1, 10:C} *\n", "Profit After Fee:", profitAfterFee);
            result += String.Format("**********************************\n");
            return result;
        }
    }
}
