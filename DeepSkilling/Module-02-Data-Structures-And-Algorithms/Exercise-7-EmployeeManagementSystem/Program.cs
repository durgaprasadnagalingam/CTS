using System;
using System.Collections.Generic;

class Employee
{
    public int Id;
    public string Name = "";
    public double Salary;
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee{Id=101,Name="Rahul",Salary=45000},
            new Employee{Id=102,Name="Priya",Salary=55000},
            new Employee{Id=103,Name="Kiran",Salary=60000}
        };

        foreach(Employee e in employees)
        {
            Console.WriteLine($"{e.Id} {e.Name} {e.Salary}");
        }
    }
}