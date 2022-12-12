using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class CalWagesTillConditionUC6
    {
        public const int fullTime = 1, partTime = 2, Emp_Rate_Per_Hrs = 20, numWorkingDays = 20, MaxHrsInMonth = 100;
        public void DayMonthCondition()
        {
            int empHrs = 0, empWage = 0, TotalWorkingDays = 0, totalEmpHrs = 0;

            while (totalEmpHrs <= MaxHrsInMonth && TotalWorkingDays < numWorkingDays)
            {
                TotalWorkingDays++;
                Random randomObj = new Random();
                int checkPresent = randomObj.Next(0, 3);
                Console.WriteLine("Random Number is " + checkPresent);

                switch (checkPresent)
                {
                    case fullTime:
                        empHrs = 8;
                        Console.WriteLine("Employee is Present");
                        break;

                    case partTime:
                        empHrs = 4;
                        Console.WriteLine("Employee is Present");
                        break;

                    default:
                        empHrs = 0;
                        Console.WriteLine("Employee is Absent");
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Days :" + TotalWorkingDays + "EmployeeHrs :" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * Emp_Rate_Per_Hrs;
            Console.WriteLine("Total Emp Wage :" + totalEmpWage);
        }
    }
}
