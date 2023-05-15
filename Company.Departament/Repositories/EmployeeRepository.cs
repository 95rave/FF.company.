using FFBusiness.Interface1;
using FFBusiness.Models;
using System.Collections.Generic;
using System.Linq;

public class EmployeeRepository : IEmployeeRepository
{
    private readonly List<Employee> _employees;

    public EmployeeRepository()
    {
        _employees = new List<Employee>();
    }

    public Employee Create(decimal salary, string name, string surname)
    {
        var employee = new Employee(salary, name, surname);
        _employees.Add(employee);
        return employee;
    }
    public Employee GetById(int id)
    {
        return _employees.FirstOrDefault(e => e.Id == id);
    }

    public List<Employee> GetAll()
    {
        return _employees;
    }
}