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

            SwitchCaseDailyWage dailyWage = new SwitchCaseDailyWage();
            dailyWage.EmployeeWageSwitch();
        }
    }
}