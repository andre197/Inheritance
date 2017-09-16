
using System;
using System.Linq;
using System.Text;

public class Student : Human
{
    private string facultyNumber;

    public Student(string firstName, string lastName, string facultyNumber) : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    protected string FacultyNumber
    {
        set
        {
            if (!value.All(char.IsLetterOrDigit) || value.Length < 5 || value.Length > 10)
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(base.ToString())
            .AppendLine($"Faculty number: {this.facultyNumber}");
        return sb.ToString();
    }
}

