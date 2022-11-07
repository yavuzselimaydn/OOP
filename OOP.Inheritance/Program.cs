using OOP.Inheritance;

internal partial class Program
{
    private static void Main(string[] args)
    {
        var s1 = new Rectangle(20, 65);
        Console.WriteLine("{0},{1}",s1.X,s1.Y);

        var s2 = new Circle(25, 78);
        Console.WriteLine("{0},{1}", s2.X, s2.Y);

        var s3 = new Square(56, 85);
        Console.WriteLine("{0},{1}", s3.X, s3.Y);

        s1.WorkwithDifferentObjects(23);
        
        

        Console.ReadLine();
    }

    private static void Polymorphism()
    {
        var shapes = new List<Shape>()
        {
            new Triangle(),
            new Circle(),
            new Rectangle(),
            new Square(),
        };

        foreach (var shape in shapes)
        {
            shape.Draw();
        }

        new Square().Calculate();
    }

    private static void virtualKeyword()
    {
        var _s1 = new Rectangle();
        var _s2 = new Circle();

        _s1.X = 10;
        _s1.Y = 10;
        _s1.Draw();
        Console.WriteLine("{0},{1}", _s1.X, _s1.Y);

        _s2.X = 25;
        _s2.Y = 258;
        _s2.Draw();
        Console.WriteLine("{0},{1}", _s2.X, _s2.Y);

        new Triangle().Draw();
    }
}