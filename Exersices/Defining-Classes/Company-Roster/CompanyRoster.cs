using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace Company_Roster
{
    class CompanyRoster
    {
        static void Main()
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Employee> employees=new List<Employee>();

            for (int i = 0; i < numberOfLines; i++)
            {
                var employeeInfo = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

                var employee=new Employee(
                    employeeInfo[0],
                    decimal.Parse(employeeInfo[1]),
                    employeeInfo[2],
                    employeeInfo[3]);

                if (employeeInfo.Length == 5)
                {
                    var emailOrAge = employeeInfo[4];

                    if (emailOrAge.Contains("@"))
                    {
                        employee.email = emailOrAge;
                    }
                    else
                    {
                        employee.age = int.Parse(emailOrAge);
                    }


                }
                else if(employeeInfo.Length == 6)
                {
                    employee.email = employeeInfo[4];
                    employee.age = int.Parse(employeeInfo[5]);
                }

                employees.Add(employee);
            }

            var result = employees
                .GroupBy(e => e.deparment)
                .Select
                (
                    e =>
                        new
                        {
                            Departmen = e.Key,
                            Salary = e.Average(emp => emp.salary),
                            Employees=e.OrderByDescending(emp=>emp.salary)
                        }
                )
                .OrderByDescending(e => e.Salary)
                .FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {result.Departmen}");

            foreach (var employee in result
                .Employees)
            {
                Console.WriteLine($"{employee.name} {employee.salary:f2} {employee.email} {employee.age}");
            }
        }
    }
}
