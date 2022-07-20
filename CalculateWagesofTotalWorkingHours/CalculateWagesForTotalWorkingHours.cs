using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateWagesofTotalWorkingHours
{
    internal class CalculateWagesForTotalWorkingHours
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;
        public const int EMP_RATE_PER_HOUR = 20;
        public const int NUMBER_OF_WORKING_DAYS = 3;
        public const int MAXIMUM_HOURS_IN_MONTH = 15;
        public static void CalculateWage()
        {
            int empHrs = 0;
            int totalempHrs = 0;
            int totalWorkingdays = 0;
            while (totalempHrs< NUMBER_OF_WORKING_DAYS)
            {
               totalWorkingdays++;
                Random random = new Random();
                int empCheck = random.Next(0,3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                 
                }
                totalempHrs = empHrs * EMP_RATE_PER_HOUR;
                Console.WriteLine("Emp Wage : " +totalempHrs);
            }
        }
    }
}
