using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class PartTimeEmployeeWage
    {
        public void PartEmployeeWage()
        {
            int Is_full_time = 1;
            int Emp_rate_per_hour = 20;
            int Is_part_time = 2;

            int empHrs = 0;
            int empWages = 0;

            Random random = new Random();
            int empCheck = random.Next(3);

            if (empCheck == Is_full_time)
            {
                empHrs = 8;
            }
            else if (empCheck == Is_part_time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }

            empWages = empHrs * Emp_rate_per_hour;
            Console.WriteLine("Employee Wage = " + empWages);
        }
    }
}
