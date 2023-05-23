using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employeeWageComputationProblem
{
    internal class EmployeeWageMonth1
    {
        public string Name1 { get; set; }
        public decimal HourlyRate1 { get; set; }
        public int MaxWorkingHours { get; set; }
        public int MaxWorkingDays { get; set; }

        public decimal CalculateWages1()
        {
            int totalWorkingHours = 0;
            int totalWorkingDays = 0;
            decimal wages1 = 0;

            while (totalWorkingHours < MaxWorkingHours && totalWorkingDays < MaxWorkingDays)
            {
                wages1 += HourlyRate1; // Assuming 1 working hour per day
                totalWorkingHours++;
                totalWorkingDays++;
            }

            return wages1;
        }
    }

}

