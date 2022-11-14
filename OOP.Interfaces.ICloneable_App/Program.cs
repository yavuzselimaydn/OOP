using OOP.Interfaces.ICloneable_App;

internal class Program
{
    private static void Main(string[] args)
    {
        var book1 = new Book()
        {
            Id = 1,
            Title = "Suç ve Ceza",
            Price = 25.5
        };

        var book2 = (Book)book1.Clone();
        book2.Title = "Sefiller";

        Console.WriteLine(book1.Id + " " + book1.Title);
        Console.WriteLine(book2.Id + " " + book2.Title);


        Console.ReadKey();
    }
}