namespace ExtensionMethods;

public static class ExtensionMethodExample
{
    public static void Run()
    {
        var data = new DateTime(2023,10,10,10,10,10);
        var dinheiro = 8900.45;
        
        Console.WriteLine("Extension Method");
        Console.WriteLine($"Formatando data {data.PtBr()}");
        Console.WriteLine($"Formatando dinheiro {dinheiro.PtBr()}");
    }
}