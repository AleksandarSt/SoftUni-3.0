using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework_Introduction
{
    class Program
    {
        static void Main()
        {
            SoftuniContext context=new SoftuniContext();

            //var employees = context.Employees;
            StringBuilder result=new StringBuilder();

            ////3.	Employees full information
            //foreach (var employee in employees)
            //{
            //    result.AppendLine(
            //        $"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary}");
            //}


            ////4.	Employees with Salary Over 50 000
            //var employeesFirstName = employees.Where(e => e.Salary > 50000).Select(e => e.FirstName);

            //foreach (var name in employeesFirstName)
            //{
            //    result.AppendLine($"{name}");
            //}

            ////5.	Employees from Seattle
            //var employees = context.Employees
            //    .Where(e => e.Department.Name == "Research and Development ")
            //    .OrderBy(e => e.Salary)
            //    .ThenByDescending(e => e.FirstName);

            //foreach (var employee in employees)
            //{
            //    result.AppendLine(
            //        $"{employee.FirstName} {employee.LastName} from {employee.Department.Name} - ${employee.Salary:f2}");
            //}

            //6.	Adding a New Address and Updating Employee

            //var address=new Address
            //{
            //    AddressText = "Vitoshka 15",
            //    TownID = 4
            //};

            //context.Addresses.Add(address);

            //Employee employee = null;

            ////todo get employee with last name 'Nakov'

            //employee = context.Employees.FirstOrDefault(e => e.LastName == "Nakov");

            ////todo set address to new addres

            //employee.Address = address;

            //context.SaveChanges();

            var addresses = context.Employees
                .OrderByDescending(e => e.AddressID)
                .Select(e=>e.Address)
                .Take(10);

            foreach (var address in addresses)
            {
                result.AppendLine($"{address.AddressText}");
            }

            Console.WriteLine(result);
        }
    }
}
