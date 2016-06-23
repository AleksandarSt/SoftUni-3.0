namespace Company_Roster
{
    public class Employee
    {
        public string name;
        public decimal salary;
        public string position;
        public string deparment;
        public string email;
        public int age;

        public Employee(string name, decimal salary, string position, string department)
        {
            this.name = name;
            this.salary = salary;
            this.position = position;
            this.deparment = department;
        }

        public Employee(string email, string name, decimal salary, string position, string department)
            : this(name, salary, position, department)
        {
            this.email = email;
        }

        public Employee(int age, string email, string name, decimal salary, string position, string department)
            : this(email, name, salary, position, department)
        {
            this.age = age;
        }
    }
}
