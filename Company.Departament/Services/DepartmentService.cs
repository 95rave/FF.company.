using Company.Departament.Models;
using System;
using System.Collections.Generic;

namespace Company.Departament.Services
{
    public class DepartmentService
    {
        private readonly List<Department> departments;

        public DepartmentService()
        {
            departments = new List<Department>();
        }

        public Department CreateDepartment(string name, int employeeLimit, int companyId)
        {
            Department department = new Department(name, employeeLimit, companyId);
            departments.Add(department);
            return department;
        }

        public void AddEmployeeToDepartment(Employee employee, Department department)
        {
            department.AddEmployee(employee);
        }

        public List<Employee> GetDepartmentEmployees(Department department)
        {
            return department.GetEmployees();
        }

        public void UpdateDepartment(Department department, string newName, int newEmployeeLimit)
        {
            department.UpdateDepartment(newName, newEmployeeLimit);
        }

        public void RemoveDepartment(Department department)
        {
            departments.Remove(department);
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
