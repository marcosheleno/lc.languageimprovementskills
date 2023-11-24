using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._4.Shared.SharedFoo;

namespace GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._3.Feature.FeatureFoo;

public class Foo2Request: IType
{
    public void Do()
    {
        Console.WriteLine("Request foo 2");
    }
    public void Do2()
    {
        Console.WriteLine("only two do");
    }
}