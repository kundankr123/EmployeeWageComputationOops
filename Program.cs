using EmployeeWagecomputation;

namespace EmployeeWageComputationOOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            
            //CheckEmployee employee = new CheckEmployee();
            //employee.EmployeeCheck();

            //DailyEmployeeWage day = new DailyEmployeeWage();
            //day.Employeewage();

            //PartTimeEmployeeWage employeeWage = new PartTimeEmployeeWage();
            //employeeWage.PartEmployeeWage();

            //SwitchCaseDailyWage dailyWage = new SwitchCaseDailyWage();
            //dailyWage.EmployeeWageSwitch();

            //EmployeeWageofMonth wageofMonth = new EmployeeWageofMonth();
            //wageofMonth.EmployeeWageMonth();

            //TotalWageWhileLoop MonthlyWage = new TotalWageWhileLoop();
            //MonthlyWage.EmployeeWageMonthWhile();

            //MonthlyWageUsingClassVarAndMethod MonthlyWage = new MonthlyWageUsingClassVarAndMethod();
            //MonthlyWage.EmployeeWageOfMonth();

            EmployeeWageMultipleComapnies capgemini = new EmployeeWageMultipleComapnies();
            capgemini.computeEmpWage("capgemini", 20, 20, 100);
            EmployeeWageMultipleComapnies tcs = new EmployeeWageMultipleComapnies();
            tcs.computeEmpWage("tcs", 15, 24, 95);
        }
    }
}