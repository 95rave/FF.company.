using Company.Departament.Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Models
{
    public class Employee: IEntity
    {
        private static int count = 0;

        public int Id { get; }
        public decimal Salary { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int DepartmentId { get; set; }

        public Employee(decimal salary, string name, string surname, int departmentId)
        {
            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                throw new ArgumentException("Name and surname cannot be empty.");
            }

            Id = ++count;
            Salary = salary;
            Name = name;
            Surname = surname;
            DepartmentId = departmentId;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}";
        }
        public static Employee Create(decimal salary, string name, string surname, int departmentId)
        {
            return new Employee(salary, name, surname, departmentId);
        }
    }
}
 


