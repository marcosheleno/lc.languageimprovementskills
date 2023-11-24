using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._4.Shared.SharedFoo;

namespace GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._3.Feature.FeatureFoo;

public class Foo1Request: IType
{
    public void Do()
    {
        Console.WriteLine("Request foo 1");
    }
    public void Do1()
    {
        Console.WriteLine("only one do");
    }
}