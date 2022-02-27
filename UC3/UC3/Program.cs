//  # Add Part time Employee & Wage
using System;

namespace UC3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PART_TIME = 1;
            int FULL_TIME = 2;
            int EMP_RATE_PER_HOUR = 20;
            int empHrs = 8;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == PART_TIME)
            {
                empHrs = 4;
            }
            else if (empCheck == FULL_TIME)
            {
                empHrs = 8;
            }
            else
            {
                empHrs = 0;
            }

            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage:" +empWage);

         
        }



    }
}
