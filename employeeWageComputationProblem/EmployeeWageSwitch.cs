using System;

namespace employeeWageComputationProblem
{
    internal class EmployeeWageSwitch
    {
        public int WagePerHour { get; private set; }
        public int FullDayHours { get; private set; }
        public int PartTimeHours { get; private set; }

        public EmployeeWageSwitch(int wagePerHour, int fullDayHours, int partTimeHours)
        {
            WagePerHour = wagePerHour;
            FullDayHours = fullDayHours;
            PartTimeHours = partTimeHours;
        }

        public int CalculateDailyWage1(string employeeType)
        {
            int dailyWage = 0;

            switch (employeeType)
            {
                case "full-time":
                    dailyWage = WagePerHour * FullDayHours;
                    break;
                case "part-time":
                    dailyWage = WagePerHour * PartTimeHours;
                    break;
                default:
                    Console.WriteLine("Invalid employee type.");
                    break;
            }

            return dailyWage;
        }
    }

}