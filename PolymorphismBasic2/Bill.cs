using Exemplo2.Pagamentos;

namespace Exemplo2;

public class Bill
{
    private readonly PaymentMethodFactory _paymentMethod;
    public int Value { get; set; }

    public Bill(PaymentMethodFactory paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void Pay(string metodo)
    {
        // _paymentMethod.Pay(Value);
    }
}