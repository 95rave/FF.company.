using FFBusiness.Interface1;
using FFBusiness.Models;
using FFBusiness.Repostory;
using System;

class Program
{
    static void Main(string[] args)
    {
        IEmployeeRepository employeeRepository = new EmployeeRepository();
        IDepartmentRepository departmentRepository = new DepartmentRepository();
        ICompanyRepository companyRepository = new CompanyRepository();

        EmployeeService employeeService = new EmployeeService(employeeRepository);
        DepartmentService departmentService = new DepartmentService(departmentRepository);
        CompanyService companyService = new CompanyService(companyRepository);
        string companyNameToGetDepartments;


        while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create Employee");
            Console.WriteLine("2. Create Department");
            Console.WriteLine("3. Create Company");
            Console.WriteLine("4. Add Employee to Department");
            Console.WriteLine("5. Update Department");
            Console.WriteLine("6. Get Department Employees");
            Console.WriteLine("7. Get All Departments of a Company");
            Console.WriteLine("8. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter employee salary: ");
                    decimal salary = decimal.Parse(Console.ReadLine());
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter employee surname: ");
                    string surname = Console.ReadLine();

                    try
                    {
                        Employee createdEmployee = employeeService.CreateEmployee(salary, name, surname);
                        Console.WriteLine("Employee created with ID: " + createdEmployee.Id);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "2":
                    Console.Write("Enter department name: ");
                    string departmentName = Console.ReadLine();
                    Console.Write("Enter department employee limit: ");
                    int employeeLimit = int.Parse(Console.ReadLine());
                    Console.Write("Enter department company ID: ");
                    int companyId = int.Parse(Console.ReadLine());

                    try
                    {
                        Department createdDepartment = departmentService.CreateDepartment(departmentName, employeeLimit, companyId);
                        Console.WriteLine("Department created with ID: " + createdDepartment.Id);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "3":
                    Console.Write("Enter company name: ");
                    string companyName = Console.ReadLine();

                    try
                    {
                        Company createdCompany = companyService.CreateCompany(companyName);
                        Console.WriteLine("Company created with ID: " + createdCompany.Id);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "4":
                    Console.Write("Enter department ID: ");
                    int departmentId = int.Parse(Console.ReadLine());
                    Console.Write("Enter employee ID: ");
                    int employeeId = int.Parse(Console.ReadLine());

                    Department department = departmentService.GetDepartmentById(departmentId);
                    Employee employee = employeeService.GetEmployeeById(employeeId);

                    if (department != null && employee != null)
                    {
                        departmentService.AddEmployeeToDepartment(department, employee);
                        Console.WriteLine("Employee added to department.");
                    }
                    else
                    {
                        Console.WriteLine("Department or employee not found.");
                    }
                    break;

                case "5":
                    Console.Write("Enter department ID: ");
                    int departmentIdToUpdate = int.Parse(Console.ReadLine());
                    Console.Write("Enter new department name: ");
                    string newDepartmentName = Console.ReadLine();
                    Console.Write("Enter new employee limit: ");
                    int newEmployeeLimit = int.Parse(Console.ReadLine());

                    Department departmentToUpdate = departmentService.GetDepartmentById(departmentIdToUpdate);

                    if (departmentToUpdate != null)
                    {
                        try
                        {
                            departmentService.UpdateDepartment(departmentToUpdate, newDepartmentName, newEmployeeLimit);
                            Console.WriteLine("Department updated successfully.");
                        }
                        catch (ArgumentException ex)
                        {
                            Console.WriteLine("Error: " + ex.Message);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Department not found.");
                    }
                    break;

                case "6":
                    Console.Write("Enter department name: ");
                    string departmentNameToGetEmployees = Console.ReadLine();

                    try
                    {
                        departmentService.GetDepartmentEmployees(departmentNameToGetEmployees);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "7":
                    Console.Write("Enter company name: ");
                    companyNameToGetDepartments = Console.ReadLine();

                    try
                    {
                        var departments = companyService.GetAllDepartments(companyNameToGetDepartments);
                        Console.WriteLine("Departments of the company:");
                        foreach (var department in departments)
                        {
                            Console.WriteLine("ID: " + department.Id + " Name: " + department.Name);
                        }
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "8":
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

            Console.WriteLine();
        }
    }
}
