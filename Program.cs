using System;

namespace MultipleCompanyUsingInterface
{
    public class Program
    {
        static void Main(string[] args)
        {
           EmpWageBuilderArray empWage = new EmpWageBuilderArray();
            empWage.addCompanyEmpWage("DMart", 20, 2, 10);
            empWage.addCompanyEmpWage("Reliance", 10, 4, 20);
            empWage.Uc_10_EmpWageForMultiCompanyUsingInterface();
        }
    }
}
