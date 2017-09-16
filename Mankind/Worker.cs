
using System;
using System.Text;

public class Worker : Human
{

    private decimal weekSalary;
    private int hoursPerDay;

    public Worker(string firstName, string lastName, decimal weekSalary, int hoursPerDay) : base(firstName, lastName)
    {
        this.WeekSalary = weekSalary;
        this.HoursPerDay = hoursPerDay;
    }

    protected decimal WeekSalary
    {

        set
        {
            if (value<=10)
            {
                throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
            }
            this.weekSalary = value;
        }
    }

    protected int HoursPerDay
    {
        set
        {
            if (value<1||value>12)
            {
                throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
            }
            this.hoursPerDay = value;
        }
    }

    private decimal SalaryPerHour()
    {
        decimal weekSalary = this.weekSalary;
        int hoursperday = this.hoursPerDay;

        var result = weekSalary / (hoursperday * 5);
        return result;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Week Salary: {this.weekSalary:f2}")
            .AppendLine($"Hours per day: {this.hoursPerDay:f2}")
            .AppendLine($"Salary per hour: {SalaryPerHour():f2}");
        return sb.ToString();
    }
}

