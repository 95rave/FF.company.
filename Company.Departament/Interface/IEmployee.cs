using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    public interface IEmployee:IEntity
    {
        decimal Salary { get; set; }
        string Surname { get; set; }
        int DepartmentId { get; set; }
    }
}
