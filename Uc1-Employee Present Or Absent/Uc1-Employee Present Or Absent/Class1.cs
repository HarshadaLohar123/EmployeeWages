using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uc1_Employee_Present_Or_Absent
{
    public class Class1
    {
            Random obj = new Random();
            int Is_Full_Time = 1;
            int Is_Part_Time = 2;
          public void Uc1Employee()
          {
                int empCheck = obj.Next(0, 2);
                if (empCheck == Is_Full_Time)
                {
                    Console.WriteLine("Employee is Present");
                }
                else
                {
                    Console.WriteLine("Employee is Absent");
                }
          }       
    }
}

    

