using OOP.Interfaces.IComparableApp;

internal class Program
{
    private static void Main(string[] args)
    {
        var employees = new List<Employee>()
        {
            new Employee()
                {
                    Id = 1,
                    FullName = "Ahmet Bahadır",
                    Salary= 10000
                },
            new Employee()
                {
                    Id= 2,
                    FullName = "Serhat Can",
                    Salary = 5000

                },
            new Employee()
                {
                    Id= 3,
                    FullName = "Emre Kan",
                    Salary = 30000

                },
            new Employee()
                {
                    Id= 4,
                    FullName = "Yağız İpek",
                    Salary = 7000

                },
            new Employee()
                {
                    Id= 5,
                    FullName = "Murat Bey",
                    Salary = 5500

                },
            new Employee()
                {
                    Id= 6,
                    FullName = "Mehmet Ateş",
                    Salary = 15500

                }
        };

        employees.Sort();

        foreach (var emp in employees)
        {
            Console.WriteLine(emp);
        }


        Console.ReadLine();
    } 
}