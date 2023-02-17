using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputationOOPS
{
    public class CheckEmployee
    {
        public void EmployeeCheck()
        {
            int Is_full_time = 1;
            Random random = new Random ();
            int empCheck = random.Next(2);

            if (empCheck == Is_full_time) 
            {
                Console.WriteLine("Employee is present.");
            }
            else
            {
                Console.WriteLine("Employee is absent.");
            }
        }
    }
}
