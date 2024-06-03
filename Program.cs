// Generic Interface
// a test for using generic interface

using GenericInterface;

Collection<Employee> employes = new Collection<Employee>();
Employee e1 = new Employee(1001, "Amin", "G82");
Employee e2 = new Employee(1002, "Stive", "Jobs");
Employee e3 = new Employee(1003, "Mark", "Zakerberg");

employes.Add(e1);
employes.Add(e2);
employes.Add(e3);

for(int i = 0; i < employes.Count; i++)
{
    Employee e = employes.Get(i);
    Console.WriteLine($" Id : {e.Id}");
    Console.WriteLine($" Name : {e.Name}");
    Console.WriteLine($" Family : {e.Family} \n\n");
}



