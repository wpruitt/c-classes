using System;
using System.Collections.Generic;

namespace classes
{
    public class Company
    {
        /*
            Some readonly properties
        */
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        public List<Employee> newList {get; set;}
        // Create a method that allows external code to add an employee
        public void AddToEmployeeList(Employee employeeObj)
        {
            newList.Add(employeeObj);
        }
        // // Create a method that allows external code to remove an employee
        public void RemoveFromEmployeeList(Employee employeeObj)
        {
            newList.Remove(employeeObj);
        }

        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string companyName, DateTime dateCreated)
        {
            Name = companyName;
            CreatedOn = dateCreated;
        }

    }

    public class Employee
    {
        public string Name { get; set; }
        public string JobTitle { get; set; }

        public DateTime StartDate { get; set; }

        public Employee(string name, string jobtitle, DateTime startdate)
        {
            Name = name;
            JobTitle = jobtitle;
            StartDate = startdate;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Company rh = new Company("RamenHunters", DateTime.Now);
            Console.WriteLine(rh.CreatedOn);
            rh.newList = new List<Employee>();
            Employee E01 = new Employee("Willie", "Taste Tester", DateTime.Now);
            rh.AddToEmployeeList(E01);
            Console.WriteLine(E01.Name);
            Employee E02 = new Employee("Darrin", "Planner", DateTime.Now);
            rh.AddToEmployeeList(E02);
            Console.WriteLine(rh.newList.Count);
            rh.RemoveFromEmployeeList(E02);
            Console.WriteLine(rh.newList.Count);

        }
    }
}
