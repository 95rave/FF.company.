using FFBusiness.Interface1;
using FFBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class CompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public Company CreateCompany(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Company name cannot be empty.");
        }

        return _companyRepository.Create(name);
    }

    public Company GetCompanyById(int id)
    {
        return _companyRepository.GetById(id);
    }

    public List<Company> GetAllCompanies()
    {
        return _companyRepository.GetAll();
    }

    public List<Department> GetAllDepartments(string companyName)
    {
        var company = _companyRepository.GetAll().FirstOrDefault(c => c.Name.ToLower() == companyName.ToLower());
        if (company == null)
        {
            throw new ArgumentException("Company not found.");
        }

        return company.Departments;
    }
}
