namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public class TestClass2
{
    private readonly IClass<Class2> _class2;

    public TestClass2(IClass<Class2> class2)
    {
        _class2 = class2;
    }

    public void Do()
    {
        _class2.Do();
    }
}