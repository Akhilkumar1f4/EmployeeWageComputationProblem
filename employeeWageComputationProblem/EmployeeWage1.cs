using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputationProblem
{
    internal class EmployeeWage1
    {
        public int WagePerHour { get; private set; }
        public int FullDayHours { get; private set; }
        public int PartTimeHours { get; private set; }

        public EmployeeWage1(int wagePerHour, int fullDayHours, int partTimeHours)
        {
            WagePerHour = wagePerHour;
            FullDayHours = fullDayHours;
            PartTimeHours = partTimeHours;
        }

        public int CalculateDailyWage(bool isFullTime)
        {
            int dailyWage = 0;

            if (isFullTime)
                dailyWage = WagePerHour * FullDayHours;
            else
                dailyWage = WagePerHour * PartTimeHours;

            return dailyWage;
        }
    }
}

    