using System;
// #Check Employee is Present or Absent

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int FULL_TIME = 1;
            Random random = new Random();
            int empCheck = random.Next(0 ,2);
            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("emp is present");

            }
            else 
            {
                Console.WriteLine("emp is absent");
            }
        }
    }
}
