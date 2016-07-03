using System;
using System.Text;

namespace Mankind.Models
{
    public class Worker:Human
    {
        public const int WorkingDaysPerWeek = 5;

        private int hours;
        private decimal salary;

        public Worker(string firstName, string lastName, decimal salary, int hours) 
            : base(firstName, lastName)
        {
            this.Salary = salary;
            this.Hours = hours;
        }

        public int Hours
        {
            get { return this.hours; }
            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }
                this.hours = value;
            }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set
            {
                if (value <= 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.ToString())
                .Append("Week Salary: ").Append($"{this.Salary:F2}")
                .Append(Environment.NewLine)
                .Append("Hours per day: ").Append($"{this.hours:F2}")
                .Append(Environment.NewLine)
                .Append("Salary per hour: ").Append($"{GetSalaryByHour(this.Salary, this.Hours):F2}")
                .Append(Environment.NewLine);

            return sb.ToString();
        }

        public decimal GetSalaryByHour(decimal weeklySalary, int hoursPerDay)
        {
            return weeklySalary/(hoursPerDay*WorkingDaysPerWeek);
        }
    }
}
