using Company.Departament.Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Models
{
    public class Department: IEntity
    {
        private static int count = 0;
        private List<Employee> employees;

        public int Id { get; }
        public string Name { get; set; }
        public int EmployeeLimit { get; set; }
        public int CompanyId { get; set; }

        public Department(string name, int employeeLimit, int companyId)
        {
            Id = ++count;
            Name = name;
            EmployeeLimit = employeeLimit;
            CompanyId = companyId;
            employees = new List<Employee>();
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }

        public void AddEmployee(Employee employee)
        {
            if (employees.Count >= EmployeeLimit)
            {
                throw new CapacityLimitException("Employee limit has been reached.");
            }

            employee.DepartmentId = Id;
            employees.Add(employee);
        }

        public void UpdateDepartment(string newName, int newEmployeeLimit)
        {
            Name = newName;
            EmployeeLimit = newEmployeeLimit;
        }

        public void GetDepartmentEmployees()
        {
            Console.WriteLine($"Employees in {Name} department:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
        public static Department Create(string name, int employeeLimit, int companyId)
        {
            return new Department(name, employeeLimit, companyId);
        }
    }

   
    

}
