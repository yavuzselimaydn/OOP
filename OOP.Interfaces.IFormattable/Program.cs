using OOP.Interfaces.IFormattables;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine(DateTime.Now.ToString("d"));
        var list = new List<Employee>()
        {
            new Employee()
            {
                Id = 1,
                Title = "Prof. Dr.",
                FirstName = "Ahmet",
                LastName = "Dağ"
            },
            new Employee()
            {
                Id = 2,
                Title = "Prof. Dr.",
                FirstName = "Yusuf",
                LastName = "Değirmenci"
            },
            new Employee()
            {
                Id = 3,
                Title = "Dr.",
                FirstName = "Yavuz",
                LastName = "Çiçek"
            },
            new Employee()
            {
                Id = 4,
                Title = "Doç. Dr.",
                FirstName = "Murat",
                LastName = "Kısa"
            }
        };

        Console.WriteLine(list[0].ToString("F"));
        Console.WriteLine(list[0].ToString("FL"));
        Console.WriteLine(list[0].ToString("LF"));
        Console.WriteLine(list[0].ToString("S"));


        Console.ReadKey();
    }
}