using System;

namespace EmpWageForMultipleCompany
{
    public class Program
    {
        static void Main(string[] args)
        {
            EmpWage empWage = new EmpWage();
            empWage.Uc_8_EmpWageForMultipleCompany("DMart", 20, 2, 10);
            empWage.Uc_8_EmpWageForMultipleCompany("Reliance", 10, 4, 20);
        }
    }
}
