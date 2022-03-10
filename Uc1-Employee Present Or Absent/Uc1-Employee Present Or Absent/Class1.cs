using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1_Employee_Present_Or_Absent
{
    public class Class1
    {
        public void Uc1Employee()
        {
            int IS_PRSENT = 1;
            int IS_ABSENT = 0;
            Random random = new Random();

            int empCheck = random.Next(0, 2);

            if (empCheck == IS_PRSENT)
            {
                Console.WriteLine("Employee Is Present");

            }
            else
            {
                Console.WriteLine("Employee Is Absent");

            }
        }

    }
}
