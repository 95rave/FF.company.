using Company.Departament.Interface1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Company.Departament.Models
{
    public class Company: IEntity
    {
        private static int count = 0;
        private List<Department> departments;

        public int Id { get; }
        public string Name { get; set; }

        public Company(string name)
        {
            Id = ++count;
            Name = name;
            departments = new List<Department>();
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }

        public static Company Create(string name)
        {
            return new Company(name);
        }
    }

}
