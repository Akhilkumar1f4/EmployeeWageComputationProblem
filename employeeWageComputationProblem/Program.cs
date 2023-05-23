
using employeeWageComputationProblem;
internal class Program
{
    private static void Main(string[] args)
    {
        EmployeeAttendance employee = new EmployeeAttendance();
        employee.DisplayAttendance();


        EmployeeWage employee1 = new EmployeeWage(10, 8);
        int dailyWage = employee1.CalculateDailyWage();
        Console.WriteLine("Daily Wage: $" + dailyWage);

        EmployeeWage1 employee2 = new EmployeeWage1(10, 8, 4);
        int fullTimeWage = employee2.CalculateDailyWage(true);
        Console.WriteLine("Full-Time Daily Wage: $" + fullTimeWage);
        int partTimeWage = employee2.CalculateDailyWage(false);
        Console.WriteLine("Part-Time Daily Wage: $" + partTimeWage);


        EmployeeWageSwitch employee3 = new EmployeeWageSwitch(10, 8, 4);
        int fullTimeWage1 = employee3.CalculateDailyWage1("full-time");
        Console.WriteLine("Full-Time Daily Wage: $" + fullTimeWage);
        int partTimeWage1 = employee3.CalculateDailyWage1("part-time");
        Console.WriteLine("Part-Time Daily Wage: $" + partTimeWage);


        EmployeeWageMonth employee4 = new EmployeeWageMonth();
        employee4.Name = "John Doe";
        employee4.HourlyRate = 10.0m;
        employee4.WorkDays = 20;
        decimal wages = employee4.CalculateWages();
        Console.WriteLine("Employee Name: " + employee4.Name);
        Console.WriteLine("Wages for the month: $" + wages);


        EmployeeWageMonth1 employee5 = new EmployeeWageMonth1();
        employee5.Name1 = "John Doe";
        employee5.HourlyRate1 = 10.0m;
        employee5.MaxWorkingHours = 100;
        employee5.MaxWorkingDays = 20;
        decimal wages1 = employee5.CalculateWages1();
        Console.WriteLine("Employee Name: " + employee5.Name1);
        Console.WriteLine("Wages for the month: $" + wages1);


}
    }
 
   