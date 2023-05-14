using Company.Departament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    
    
        public interface IDepartmentService
        {
            Department AddDepartment(string name, int employeeLimit, int companyId);
            List<Department> GetAllDepartments();
            Department GetDepartmentById(int departmentId);
            void UpdateDepartmentName(int departmentId, string newName);
            void UpdateDepartmentEmployeeLimit(int departmentId, int newEmployeeLimit);
            void RemoveDepartment(int departmentId);
            void AddEmployeeToDepartment(int departmentId, Employee employee);
            void RemoveEmployeeFromDepartment(int departmentId, int employeeId);
            List<Employee> GetDepartmentEmployees(int departmentId);
        }
    

}
