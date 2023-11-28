namespace IfPerformance;

public class NullOperator
{
    public void Run()
    {
        var stringTest = CreateString() ?? "batatas";
    }

    private string? CreateString()
    {
        return "batata";
    }
}