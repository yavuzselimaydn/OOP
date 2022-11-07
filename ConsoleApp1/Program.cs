internal class Program
{
    private static void Main(string[] args)
    {
        //_firstName adında alan oluşturdum.
        private string _firstName;
    private string _lastName;

    public string FirstName
    {

        set
        {
            _firstName = value;
        }
        get
        {
            return _firstName;
        }
    }

    //Expression-bodied property accessors( CTRL .)
    public string LastName
    {
        get => _lastName;
        set => _lastName = value;
    }

    //Auto-implemented property(prop ve propfull)
    public int Age { get; set; }


    //Constructor Kullanımı (ctor)
    public Employee()
    {
    }

    //Overloading
    public Employee(string firstName, string lastName, int age)
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
    }

    //Override (Gömülü metotu değiştirme)
    public override string ToString()
    {
        return $"{FirstName} {LastName} ({Age})";
    }











    //Employee sınıfından nesne üretme - 1
    Employee employee = new Employee();

    employee.FirstName = "Yavuz";
        employee.LastName = "Aydın";
        employee.Age = 20;
        //Console.WriteLine(employee.FirstName);
        //Console.WriteLine(employee.LastName);
        //Console.WriteLine(employee.Age);
        Console.WriteLine(employee);

        //Employee sınıfından nesne üretme - 2
        Employee employee2 = new Employee("Murat", "Efendioğlu", 21);
    //Console.WriteLine(employee2.FirstName);
    //Console.WriteLine(employee2.LastName);
    //Console.WriteLine(employee2.Age);
    Console.WriteLine(employee2);

        Employee employee3 = new Employee("Ahmet", "Bahadır", 23);
    Console.WriteLine(employee3);


}
}