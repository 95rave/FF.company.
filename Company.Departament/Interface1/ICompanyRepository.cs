using FFBusiness.Models;
using System.Collections.Generic;

namespace FFBusiness.Interface1
{
    public interface ICompanyRepository
    {
        Company Create(string name);
        Company GetById(int id);
        List<Company> GetAll();
    }
}
