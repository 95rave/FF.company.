using System.Collections.Generic;

namespace FFBusiness.Models
{
    public class Company
    {
        private static int _count = 0;
        private readonly List<Department> _departments;

        public int Id { get; }
        public string Name { get; }

        public Company(string name)
        {
            Id = ++_count;
            Name = name;
            _departments = new List<Department>();
        }

        public List<Department> Departments => _departments;
    }
}
