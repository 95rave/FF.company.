using Company.Departament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
  
    
        public interface IEmployeeService
        {
            Employee AddEmployee(decimal salary, string name, string surname, int departmentId);
            List<Employee> GetAllEmployees();
            Employee GetEmployeeById(int employeeId);
            void UpdateEmployeeName(int employeeId, string newName);
            void UpdateEmployeeSurname(int employeeId, string newSurname);
            void UpdateEmployeeSalary(int employeeId, decimal newSalary);
            void RemoveEmployee(int employeeId);
        }
    

}
