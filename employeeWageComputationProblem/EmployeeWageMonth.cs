using System;

public class EmployeeWageMonth
{
    public string Name { get; set; }
    public decimal HourlyRate { get; set; }
    public int WorkDays { get; set; }

    public decimal CalculateWages()
    {
        return HourlyRate * WorkDays * 8; // Assuming 8 working hours per day
    }
}


