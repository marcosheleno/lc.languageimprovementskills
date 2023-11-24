namespace Exemplo2.Pagamentos;

public class Debito: PaymentMethod
{
    public void Pay(int value)
    {
        Console.WriteLine($"Debito {value}");
    }
}