namespace PaymentContext.Shared.Commands;
public interface ICommand
{
    void Validate()
    {
        Console.WriteLine("Cosnegui!");
    }
}
