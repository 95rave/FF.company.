using FFBusiness.Models;
using System.Collections.Generic;


namespace FFBusiness.Interface1
{
    public interface IEmployeeRepository
    {
        Employee Create(decimal salary, string name, string surname);
        Employee GetById(int id);
        List<Employee> GetAll();
    }
}
