namespace employeeWageComputationProblem
{
    internal class EmployeeWage
    {
        public int WagePerHour { get; private set; }
        public int FullDayHours { get; private set; }

        public EmployeeWage(int wagePerHour, int fullDayHours)
        {
            WagePerHour = wagePerHour;
            FullDayHours = fullDayHours;
        }

        public int CalculateDailyWage()
        {
            int dailyWage = WagePerHour * FullDayHours;
            return dailyWage;
        }
    }
}