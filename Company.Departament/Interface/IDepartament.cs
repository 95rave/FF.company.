using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    public interface IDepartament: IEntity
    {
        int EmployeeLimit { get; set; }
        int CompanyId { get; set; }
        void AddEmployee(IEmployee employee);
        void UpdateDepartment(string newName, int newEmployeeLimit);
        void GetDepartmentEmployees();
    }
}
