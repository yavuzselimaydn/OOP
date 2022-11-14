namespace OOP.Interfaces;

//interface tanımı
public interface IBankAccount 
{
    //interface içindeki üyelerin imzalarının tanımı
    void PayIn(decimal amount);
    bool Withdraw(decimal amount);
    decimal Balance { get; }

}