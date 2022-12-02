using System;

namespace EmployeeWage
{
    internal class Program
    {
        public const int fullTime = 1, partTime = 2, Emp_Rate_Per_Hrs = 20, numWorkingDays = 20;
        static void Main(string[] args)
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
                        empWage = 4;
                        Console.WriteLine("Employee is Present");
                        break;

                    default:
                        empWage = 0;
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