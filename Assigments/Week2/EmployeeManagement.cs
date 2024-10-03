using System;
using System.Collections.Generic;
using System.Text;

namespace Assigments.Week2
{
    /*
     Create an Employee class with properties like EmployeeID, Name, Designation, 
    and Salary. Add methods to display employee details and give a salary hike.
     */
    class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Employee(int employeeId, string employeeName, string designation, double salary)
        {
            EmployeeId = employeeId;
            EmployeeName = employeeName;
            Designation = designation;
            Salary = salary;
        }

        public void Display()
        {
            Console.WriteLine($"EmployeeId : {EmployeeId}, EmployeeName : {EmployeeName}, Designation : {Designation}, Salary : {Salary}");
        }

        public double SalaryHike(double hike)
        {
            Salary = Salary + (Salary * hike);
            return Salary;
        }
    }
    internal class EmployeeManagement
    {
        public static void ManagementEmployee()
        {
            Employee emp = new Employee(101,"Mahammed Ghouse","Developer",35000);
            emp.Display();
            double hike = 0.2;
            emp.SalaryHike(hike);
            Console.WriteLine("Your new salary after 20% hike is "+emp.Salary);
        }
    }
}
