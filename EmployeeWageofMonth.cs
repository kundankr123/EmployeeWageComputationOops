using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class EmployeeWageofMonth
    {
        public const int Is_full_time = 1;
        public const int Emp_rate_per_hour = 20;
        public const int Is_part_time = 2;
        public const int Num_of_wkg_days = 20;
        public void EmployeeWageMonth()
        {

            int empHrs = 0;
            int empWages = 0;
            int totalempWage = 0;

            for (int day = 0; day < Num_of_wkg_days; day++)
            {
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
                        empHrs = 0;
                        break;
                }

                empWages = empHrs * Emp_rate_per_hour;
                totalempWage += empWages;
                Console.WriteLine("Employee Wage = " + empWages);
            }
            Console.WriteLine("Total employee Wage= " + totalempWage);
         }
    }
}
