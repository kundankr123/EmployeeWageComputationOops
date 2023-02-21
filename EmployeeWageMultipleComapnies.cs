using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class EmployeeWageMultipleComapnies
    {
        public const int Is_full_time = 1;
        public const int Is_part_time = 2;
        public void computeEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int empHrs = 0;
            int totalemphrs = 0;
            int totalwkgdays = 0;

            while (totalemphrs <= maxHoursPerMonth && totalwkgdays < numOfWorkingDays)
            {
                totalwkgdays++;
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

                totalemphrs += empHrs;
                Console.WriteLine("Day #" + totalwkgdays + " EmpHrs: " + empHrs);
            }
            int totalEmpWage = totalemphrs * empRatePerHour;
            Console.WriteLine("Total emp wage for company: " + company + " is :" + totalEmpWage);
        }
    }
}
