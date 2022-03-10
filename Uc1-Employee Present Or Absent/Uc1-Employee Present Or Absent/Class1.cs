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

        int maxRateInMonth = 100;
        int Emp_Rate_Per_Hr = 20;
        int numOfWorkingDays = 20;
        int totalWorkingDay = 20;
        int empHrs = 0;
        int empWage = 0;
        int totalEmpHr = 0;
        int totalSalary = 0;


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
        public void Uc2_DailyWages()
        {
            int empCheck = obj.Next(0, 2);
            if (empCheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("He worked full day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("He is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("Employee salary is= " + empWage);
        }
        public void Uc3_PartTime()
        {
            int randomCheck = obj.Next(0, 3);
            if (randomCheck == Is_Full_Time)
            {
                empHrs = 8;
                Console.WriteLine("He Worked Full Day");
            }
            else if (randomCheck == Is_Part_Time)
            {
                empHrs = 4;
                Console.WriteLine("He Worked Half Day");
            }
            else
            {
                empHrs = 0;
                Console.WriteLine("He Is Absent");
            }
            empWage = empHrs * Emp_Rate_Per_Hr;
            Console.WriteLine("His Salary is= " + empWage);
        }
        public void Uc4_SwitchCase()
        {
            int randomCheck = obj.Next(0, 3);
            switch (randomCheck)
            {
                case 1:
                        empHrs = 8;
                        Console.WriteLine("He is working full day");
                        break;
                case 2:
                        empHrs = 4;
                        Console.WriteLine("He is working Half day");
                        break;
                case 0:
                        empHrs = 0;
                        Console.WriteLine("He is absent");
                        break;
            }
                empWage = empHrs * Emp_Rate_Per_Hr;
                Console.WriteLine("Employee one day salary is= " + empWage);
        }
        public void Uc5_WagesForAMonth()
        {
            for (int day = 1; day <= totalWorkingDay; day++)
            {
                int randomCheck = obj.Next(0, 3);
                switch (randomCheck)
                {
                    case 1:
                        empHrs = 8;
                        break;
                    case 2:
                        empHrs = 4;
                        break;
                    case 0:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * Emp_Rate_Per_Hr;
                totalSalary = (totalSalary + empWage);
            }
            Console.WriteLine("Employee total salary for a month is= " + totalSalary);
        }

        }
    }

    

