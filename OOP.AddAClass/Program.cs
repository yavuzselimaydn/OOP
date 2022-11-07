using OOP.AddAClass;

internal class Program
{
    private static void Main(string[] args)
    {
        var employee = new Employee();
        employee.Add(new Employee("Yavuz Selim", "Aydın", 21));

        employee.AddRange(
            new Employee("Ahmet", "Bahadır", 22),
            new Employee("Murat", "Efendioğlu", 24),
            new Employee("Abdullah", "Efendioğlu", 25)
        );

        var list = employee.GetEmployees();

        foreach (var e in list)
        {
            Console.WriteLine(e);
        }

        Console.ReadLine();
    }
}