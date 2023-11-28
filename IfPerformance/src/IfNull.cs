namespace IfPerformance;

public class IfNull
{
    public void Run()
    {
        var stringTest = CreateString();
        if (stringTest == String.Empty)
        {
            stringTest = "batatas";
        }
    }

    private string? CreateString()
    {
        return "batata";
    }
}