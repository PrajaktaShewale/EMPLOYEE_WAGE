using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class AttendanceUC1
    {
        public void Attendance()
        {
            int fullTime = 1;
            Random randomObj = new Random();
            int checkPresent = randomObj.Next(0, 2);
            Console.WriteLine("Random Number is " + checkPresent);
            if (checkPresent == fullTime)
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
