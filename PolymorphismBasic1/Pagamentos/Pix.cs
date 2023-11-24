namespace Exemplo1.Pagamentos;

public class Pix: PaymentMethod
{
    public void Pay(int value)
    {
        Console.WriteLine($"Pix {value}");
    }
}