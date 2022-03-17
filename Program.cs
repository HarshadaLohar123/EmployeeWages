using System;

namespace TotalWageForEachComapany
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWage dMart = new EmpWage("DMart", 20, 2, 10);
            EmpWage reliance = new EmpWage("Reliance", 10, 4, 20);
            dMart.Uc_9_EmpTotalWageForEachCompany();
            Console.WriteLine(dMart.toString());
            reliance.Uc_9_EmpTotalWageForEachCompany();
            Console.WriteLine(reliance.toString());

        }
    }
}
