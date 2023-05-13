using Company.Departament.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    public interface ICompany: IEntity
    {
        List<IDepartment> GetAllDepartments();
    }
}
