namespace GenericInterface
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }

        public Employee(int id, string name, string family)
        {
            Id = id;
            Name = name;
            Family = family;
        }
    }
}
