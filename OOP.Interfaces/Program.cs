using OOP.Interfaces;

internal partial class Program
{
    private static void Main(string[] args)
    {
        SaverAccount saver = new SaverAccount();
        saver.PayIn(1000);
        saver.Withdraw(200);
        saver.Withdraw(1000);

        Console.WriteLine("Current balance : " + saver.Balance);
        Console.WriteLine(saver);

        Console.ReadKey();
    }
}