//case statement 
using System;

namespace UC5
{
    internal class Program
    {
        public const int PART_TIME = 1;
      public  const int FULL_TIME = 2;
      public const int EMP_RATE_PER_HOUR = 20;
        static void Main(string[] args)
        {
            
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            switch (empCheck)
            {
                case PART_TIME:
                    empHrs = 4;
                    break;
                case FULL_TIME:
               empHrs = 8;
                break;
                default:
                 empHrs = 0;
                    break;

            }
            empWage = empHrs * EMP_RATE_PER_HOUR;
            Console.WriteLine("empWage:" + empWage);

        }

       
    }
}
