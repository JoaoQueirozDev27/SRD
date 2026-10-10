using Domain.value_objects;

namespace Domain.Entities
{
    public class Enterprise
    {
        public IDGuid ID { get; private set; }
        public Name Name { get; private set; }
        public Enterprise(Name name)
        {
            ID = new IDGuid();
            Name = name;
        }
        private readonly List<Employee> _employees = new();
        public IReadOnlyCollection<Employee> Employees => _employees;
        public void AddEmployee(Employee employee)
        {
            if (employee == null)
                throw new ArgumentNullException(nameof(employee));

            _employees.Add(employee);
        }
    }
}
