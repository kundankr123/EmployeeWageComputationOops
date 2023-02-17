using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class SwitchCaseDailyWage
    {
        public const int Is_full_time = 1;
        public const int Emp_rate_per_hour = 20;
        public const int Is_part_time = 2;
        public void EmployeeWageSwitch()
        {

            int empHrs = 0;
            int empWages = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            switch (empCheck)
            {
                case Is_full_time:
                    empHrs = 8;
                    break;
                case Is_part_time:
                    empHrs = 4;
                    break;
                default:
                    empHrs= 0;
                    break;
            }

            empWages = empHrs * Emp_rate_per_hour;
            Console.WriteLine("Employee Wage = " + empWages);
        }
    }
}
