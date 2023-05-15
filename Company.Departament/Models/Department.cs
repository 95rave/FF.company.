using System;
using System.Collections.Generic;


namespace FFBusiness.Models
{
    public class Department
    {
        private static int _count = 0;
        private readonly List<Employee> _employees;

        public int Id { get; }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int CompanyId { get; }

        public Department(string name, int employeeLimit, int companyId)
        {
            Id = ++_count;
            Name = name;
            EmployeeLimit = employeeLimit;
            CompanyId = companyId;
            _employees = new List<Employee>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public void AddEmployee(Employee employee)
        {
            if (_employees.Count >= EmployeeLimit)
            {
                throw new CapacityLimitException("Employee limit exceeded.");
            }

            employee.DepartmentId = Id;
            _employees.Add(employee);
        }

        public void UpdateDepartment(string newName, int newEmployeeLimit)
        {
            Name = newName;
            EmployeeLimit = newEmployeeLimit;
        }

        public void GetDepartmentEmployees()
        {
            Console.WriteLine($"Employees of {Name} Department:");
            foreach (var employee in _employees)
            {
                Console.WriteLine(employee.ToString());
            }
        }

        internal List<Employee> GetEmployees()
        {
            throw new NotImplementedException();
        }
    }
}
