// Exemplo de multiplos pagamentos, mas adicionados no construtor diretamente
// Strategy simples

using Exemplo1;
using Exemplo1.Pagamentos;

var cc = new CC();
var debito = new Debito();

var bill1 = new Bill(cc)
{
    Value = 10000
};

var bill2 = new Bill(debito)
{
    Value = 100
};

bill1.Pay();
bill2.Pay();