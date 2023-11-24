namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public class TestClass1
{
    private readonly IClass<Class1> _class1;

    public TestClass1(IClass<Class1> class1)
    {
        _class1 = class1;
    }

    public void Do()
    {
        _class1.Do();
    }
}