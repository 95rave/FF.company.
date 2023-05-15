using FFBusiness.Interface1;
using FFBusiness.Models;
using System.Collections.Generic;
using System;
using System.Linq;

public class DepartmentService
{
    private readonly IDepartmentRepository _departmentRepository;
    public DepartmentService(IDepartmentRepository departmentRepository)
    {
        _departmentRepository = departmentRepository;
    }

    public Department CreateDepartment(string name, int employeeLimit, int companyId)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new ArgumentException("Department name cannot be empty.");
        }

        return _departmentRepository.Create(name, employeeLimit, companyId);
    }

    public Department GetDepartmentById(int id)
    {
        return _departmentRepository.GetById(id);
    }

    public List<Department> GetAllDepartments()
    {
        return _departmentRepository.GetAll();
    }

    public void AddEmployeeToDepartment(Department department, Employee employee)
    {
        _departmentRepository.AddEmployeeToDepartment(department, employee);
    }

    public void UpdateDepartment(Department department, string newName, int newEmployeeLimit)
    {
        if (department == null)
        {
            throw new ArgumentNullException(nameof(department), "Department cannot be null.");
        }
        if (string.IsNullOrEmpty(newName))
        {
            throw new ArgumentException("New department name cannot be empty.");
        }

        _departmentRepository.UpdateDepartment(department, newName, newEmployeeLimit);
    }

    public void GetDepartmentEmployees(string departmentName)
    {
        var department = _departmentRepository.GetAll().FirstOrDefault(d => d.Name.ToLower() == departmentName.ToLower());
        if (department == null)
        {
            throw new ArgumentException("Department not found.");
        }

        department.GetDepartmentEmployees();
    }



}