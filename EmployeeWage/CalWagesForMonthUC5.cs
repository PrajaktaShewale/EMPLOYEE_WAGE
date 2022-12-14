using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class CalWagesForMonthUC5

    {
        public const int fullTime = 1, partTime = 2, Emp_Rate_Per_Hrs = 20, numWorkingDays = 20;
        public void Month()
        {
            int empHrs = 0, empWage = 0, monthlyempWage = 0;
            for (int day = 0; day < numWorkingDays; day++)
            {
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


                empWage = empHrs * Emp_Rate_Per_Hrs;
                monthlyempWage += empWage;
                Console.WriteLine("Emp Wage :" + empWage);
            }
            monthlyempWage = empWage * numWorkingDays;
            Console.WriteLine("Monthly Emp Wage :" + monthlyempWage);
        }
    }
}
