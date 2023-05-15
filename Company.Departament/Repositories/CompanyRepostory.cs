using FFBusiness.Interface1;
using FFBusiness.Models;
using System.Collections.Generic;
using System.Linq;

public class CompanyRepository : ICompanyRepository
{
    private readonly List<Company> _companies;
    public CompanyRepository()
    {
        _companies = new List<Company>();
    }

    public Company Create(string name)
    {
        var company = new Company(name);
        _companies.Add(company);
        return company;
    }

    public Company GetById(int id)
    {
        return _companies.FirstOrDefault(c => c.Id == id);
    }

    public List<Company> GetAll()
    {
        return _companies;
    }

    
}