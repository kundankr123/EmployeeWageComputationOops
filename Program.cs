namespace EmployeeWageComputationOOPS
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation.");
            
            CheckEmployee employee = new CheckEmployee();
            employee.EmployeeCheck();
        }
    }
}