using Exemplo1.Pagamentos;

namespace Exemplo1;

public class Bill
{
    private readonly PaymentMethod _paymentMethod;
    public int Value { get; set; }

    public Bill(PaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void Pay()
    {
        _paymentMethod.Pay(Value);
    }
}