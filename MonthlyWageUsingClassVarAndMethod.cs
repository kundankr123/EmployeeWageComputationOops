using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class MonthlyWageUsingClassVarAndMethod
    {
            public const int Is_full_time = 1;
            public const int Emp_rate_per_hour = 20;
            public const int Is_part_time = 2;
            public const int Num_of_wkg_days = 20;
            public const int Max_hrs_in_month = 100;
            public void EmployeeWageOfMonth()
            {

                int empHrs = 0;
                //int empWages = 0;
                //int totalempWage = 0;
                int totalemphrs = 0;
                int totalwkgdays = 0;

                while (totalemphrs <= Max_hrs_in_month && totalwkgdays < Num_of_wkg_days)
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
                int totalEmpWage = totalemphrs * Emp_rate_per_hour;
                Console.WriteLine("Total emp wage: " + totalEmpWage);
            }


    }

}

