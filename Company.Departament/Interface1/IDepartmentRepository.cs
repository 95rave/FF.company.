using FFBusiness.Models;
using System.Collections.Generic;

namespace FFBusiness.Interface1
{
    public interface IDepartmentRepository
    {
        Department Create(string name, int employeeLimit, int companyId);
        Department GetById(int id);
        List<Department> GetAll();
        void AddEmployeeToDepartment(Department department, Employee employee);
        void UpdateDepartment(Department department, string newName, int newEmployeeLimit);
    }
}
