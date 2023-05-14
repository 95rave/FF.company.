using System;
using System.Collections.Generic;
using System.Linq;

namespace Company.Departament.Services
{
    public class CompanyService
    {
        private readonly Dictionary<int, CompanyService> companies;

        public string Name { get; private set; }

        public CompanyService(int companyId, string name)
        {
            companies = new Dictionary<int, CompanyService>();
        }

        public CompanyService AddCompany(string name)
        {
            int companyId = GenerateCompanyId();

            CompanyService company = new CompanyService(companyId, name);
            companies.Add(companyId, company);
            return company;
        }

        public List<CompanyService> GetAllCompanies()
        {
            return companies.Values.ToList();
        }

        public CompanyService GetCompanyById(int companyId)
        {
            if (companies.TryGetValue(companyId, out CompanyService company))
            {
                return company;
            }
            return null;
        }

        public void UpdateCompanyName(int companyId, string newName)
        {
            if (companies.TryGetValue(companyId, out CompanyService company))
            {
                company.Name = newName;
            }
        }

        public void RemoveCompany(int companyId)
        {
            companies.Remove(companyId);
        }

        private int GenerateCompanyId()
        {
           
            return companies.Count + 1;
        }

      
    }
}
