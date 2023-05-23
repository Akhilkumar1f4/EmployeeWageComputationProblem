namespace employeeWageComputationProblem
{
    public class EmployeeAttendance
    {
        public bool IsPresent { get; private set; }

        public EmployeeAttendance()
        {
            MarkAttendance();
        }

        private void MarkAttendance()
        {
            Random random = new Random();
            int attendance = random.Next(0, 2);

            IsPresent = (attendance == 1);
        }

        public void DisplayAttendance()
        {
            if (IsPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }

        internal int CalculateDailyWage2(bool v)
        {
            throw new NotImplementedException();
        }

        internal int CalculateDailyWage1(bool v)
        {
            throw new NotImplementedException();
        }
    }
}


