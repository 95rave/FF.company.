namespace FFBusiness.Models
{
    public class Employee
    {
        private static int _count = 0;

        public int Id { get; }
        public decimal Salary { get; }
        public string Name { get; }
        public string Surname { get; }
        public int DepartmentId { get; set; }

        public Employee(decimal salary, string name, string surname)
        {
            Id = ++_count;
            Salary = salary;
            Name = name;
            Surname = surname;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}, Surname: {Surname}";
        }
    }
}
