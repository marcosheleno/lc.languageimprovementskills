using Python.Runtime;

namespace RunPyInCSharp;

public class RunPy
{
    private int nim = 0;
    private int taxa = 0;
    private int parcela = 0;
    public void Run()
    {
        Init();
        var pyCode = LoadScript("/Users/marcosheleno/Documents/Estudos/C#/Principios de OO/Polimorfismo/RunPyInCSharp/scripts/script.1.py");
        Console.WriteLine("comecei");
        using (Py.GIL())
        {
            using (var scope = Py.CreateScope())
            {
                scope.Set("arg1", "batata");
                scope.Exec(pyCode);
                
                nim = scope.Get<int>("nim");
                taxa = scope.Get<int>("taxa");
                parcela = scope.Get<int>("parcela");
            }
        }

        Console.WriteLine($"Nim: {nim}");
        Console.WriteLine($"Taxa: {taxa}");
        Console.WriteLine($"Parcela: {parcela}");
    }
    private void Init()
    {
        var path = "/opt/homebrew/opt/python@3.11/libexec/bin/python";
        Environment.SetEnvironmentVariable("PYTHONNET_PYDLL", path);
        PythonEngine.Initialize();
    }

    private string LoadScript(string path)
    {
        return File.ReadAllText(path);
    }
}