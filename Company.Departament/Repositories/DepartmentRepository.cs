using FFBusiness.Interface1;
using FFBusiness.Models;
using System.Collections.Generic;
using System.Linq;

namespace FFBusiness.Repostory
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly List<Department> _departments;

        public DepartmentRepository()
        {
            _departments = new List<Department>();
        }

        public Department Create(string name, int employeeLimit, int companyId)
        {
            var department = new Department(name, employeeLimit, companyId);
            _departments.Add(department);
            return department;
        }

        public Department GetById(int id)
        {
            return _departments.FirstOrDefault(d => d.Id == id);
        }

        public List<Department> GetAll()
        {
            return _departments;
        }

        public void AddEmployeeToDepartment(Department department, Employee employee)
        {
            department.AddEmployee(employee);
        }

        public void UpdateDepartment(Department department, string newName, int newEmployeeLimit)
        {
            department.UpdateDepartment(newName, newEmployeeLimit);
        }
    }
}
