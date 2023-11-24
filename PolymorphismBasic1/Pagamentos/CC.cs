namespace Exemplo1.Pagamentos;

public class CC: PaymentMethod
{
    public void Pay(int value)
    {
        Console.WriteLine($"CC {value}");
    }
}