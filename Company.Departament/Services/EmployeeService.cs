using FFBusiness.Interface1;
using FFBusiness.Models;
using System.Collections.Generic;
using System;

    public class EmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        public EmployeeService(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public Employee CreateEmployee(decimal salary, string name, string surname)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException("Name and surname cannot be empty.");
            }

            return _employeeRepository.Create(salary, name, surname);
        }

        public Employee GetEmployeeById(int id)
        {
            return _employeeRepository.GetById(id);
        }

        public List<Employee> GetAllEmployees()
        {
            return _employeeRepository.GetAll();
        }
    }

