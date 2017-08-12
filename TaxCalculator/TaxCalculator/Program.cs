using System;

namespace TaxCalculator
{
    class Program
    {
        static int[] minIncomeArray = new int[] { 20000, 30000, 40000, 80000, 120000, 160000, 200000, 320000 };
        static double[] taxRateArray = new double[] { 0.02, 0.035, 0.07, 0.115, 0.15, 0.17, 0.18, 0.20 };
        static int[] basePayableAmountArray = new int[] { 0, 200, 550, 3350, 7950, 13950, 20750, 42350 };
        static void Main(string[] args)
        {
            int annualIncome = AskForIncome();
            int taxBracket = GetBracket(annualIncome);
            double taxPayable = CalculateIncomeTax(annualIncome, taxBracket);
            PrintResult(annualIncome, taxPayable);
        }
        static int AskForIncome()
        {
            Console.Write("Please enter your annual income:");
            int annualIncome = Convert.ToInt32(Console.ReadLine());
            return annualIncome;
        }
        static int GetBracket(int annualIncome)
        {
            int taxBracket = -1;
            if (annualIncome < 2000)
            {
                taxBracket = -1;
            }
            else
            {
                for (int i = 0; i < minIncomeArray.Length; i++)
                {
                    if (minIncomeArray[i] <= annualIncome)
                    {
                        taxBracket = i;
                    }
                }
            }
            return taxBracket;
        } 
        static double CalculateIncomeTax(int annualIncome,int taxBracket)
        {
            double taxPayable = 0;
            if (taxBracket==-1)
            {
                taxPayable =0;
            }
            else
            {
                taxPayable = (annualIncome - minIncomeArray[taxBracket]) * taxRateArray[taxBracket] + basePayableAmountArray[taxBracket];
            }
            return taxPayable;
        }
        static void PrintResult(int annualIncome,double taxPayable)
        {
            Console.WriteLine("For taxable annual income of ${0:0,0.00},the tax payable amount is ${1:0,0.00}", annualIncome, taxPayable);

        }

    }
}