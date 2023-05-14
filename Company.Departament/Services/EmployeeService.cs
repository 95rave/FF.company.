using Company.Departament.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Departament.Services
{
    public class EmployeeService
    {
        private readonly List<Employee> employees;

        public EmployeeService()
        {
            employees = new List<Employee>();
        }

        public Employee AddEmployee(decimal salary, string name, string surname, int departmentId)
        {
            Employee employee = Employee.Create(salary, name, surname, departmentId);
            employees.Add(employee);
            return employee;
        }

        public List<Employee> GetEmployeesByDepartmentId(int departmentId)
        {
            return employees.Where(e => e.DepartmentId == departmentId).ToList();
        }

        public void UpdateEmployeeSalary(int employeeId, decimal newSalary)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                employee.Salary = newSalary;
            }
        }

        public void RemoveEmployee(int employeeId)
        {
            Employee employee = employees.FirstOrDefault(e => e.Id == employeeId);
            if (employee != null)
            {
                employees.Remove(employee);
            }
        }
    }
}
