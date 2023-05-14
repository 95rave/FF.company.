using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Interface1
{
    public interface ICompanyService
    {
        ICompany AddCompany(string name);
        List<ICompany> GetAllCompanies();
        ICompany GetCompanyById(int companyId);
        void UpdateCompanyName(int companyId, string newName);
        void RemoveCompany(int companyId);
    }
}
