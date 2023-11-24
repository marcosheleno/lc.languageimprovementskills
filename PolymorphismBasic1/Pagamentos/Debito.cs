namespace Exemplo1.Pagamentos;

public class Debito: PaymentMethod
{
    public void Pay(int value)
    {
        Console.WriteLine($"Debito {value}");
    }
}