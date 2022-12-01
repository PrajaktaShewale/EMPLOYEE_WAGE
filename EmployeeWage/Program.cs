using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int fullTime = 1;
            Random randomObj = new Random();
            int checkPresent = randomObj.Next(0,2);
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