using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Mankind.Models
{
    public class Human
    {
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public virtual string FirstName
        {
            get { return this.firstName; }
            set
            {
                string pattern = @"^[A-Z]";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: firstName");
                }

                this.firstName = value;
            }
        }

        public virtual string LastName
        {
            get { return this.lastName; }
            set
            {
                string pattern = @"^[A-Z]";
                Regex regex = new Regex(pattern);

                if (!regex.IsMatch(value))
                {
                    throw new ArgumentException("Expected upper case letter! Argument: lastName");
                }

                if (value.Length < 3)
                {
                    throw new ArgumentException("Expected length at least 3 symbols! Argument: lastName");
                }

                this.lastName = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("First Name: ").Append(this.FirstName)
                .Append(Environment.NewLine)
                .Append("Last Name: ").Append(this.LastName)
                .Append(Environment.NewLine);

            return sb.ToString();
        }
    }
}
