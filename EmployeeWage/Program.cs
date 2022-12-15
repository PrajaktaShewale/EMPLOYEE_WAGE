using System;

namespace EmployeeWage
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            bool flag = true;
            while (flag)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("employee Wage Problem");
                Console.ResetColor();
                Console.WriteLine("Enter a number to get perticular UC");
                Console.WriteLine("1.Attendance\n2.Calculate Daily EMP Wage\n3.Add Part Time EMP Wage\n4.Calculate EMP Wage Using Switch statement" +
                    "\n5.Calculate Wages For A month\n6.Calculate till hrs and Condition Apply\n7.Multiple Companies");
                int check = Convert.ToInt32(Console.ReadLine());
                switch(check)
                {
                    case 1:
                        AttendanceUC1 uc1 = new AttendanceUC1();
                        uc1.Attendance();
                        break;
                        case 2:
                        DailyEmpWageUC2 uc2 = new DailyEmpWageUC2();
                        uc2.DailyWage();
                        break;
                    case 3:
                        AddPartTimeEMPWageUC3 uc3 = new AddPartTimeEMPWageUC3();
                        uc3.AddParttime();
                        break;
                    case 4:
                        CalEMPWageSwitchCaseUC4 uc4 = new CalEMPWageSwitchCaseUC4();
                        uc4.SwitchCase();
                        break;
                    case 5:
                        CalWagesForMonthUC5 uc5 = new CalWagesForMonthUC5();
                        uc5.Month();
                        break;
                    case 6:
                        CalWagesTillConditionUC6 uc6 = new CalWagesTillConditionUC6();
                        uc6.DayMonthCondition();
                        break;
                    case 7:
                        EmpWageMultipleCompanies uc8 = new EmpWageMultipleCompanies();
                        uc8.EmpWageMultiple("TATA", 10, 20, 100);
                        uc8.EmpWageMultiple("Reliance", 20, 20, 80);
                        break;
                        default:
                        flag = false;
                        break;

                }
            }


        }
    }
}