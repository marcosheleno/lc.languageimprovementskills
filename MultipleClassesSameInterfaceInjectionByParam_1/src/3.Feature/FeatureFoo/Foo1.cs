
using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._4.Shared.SharedFoo;

namespace GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._3.Feature.FeatureFoo;

public class Foo1: ServiceFoo
{
    private Foo1Request _param;
    public override void Do()
    {
        Console.WriteLine("foo 1");
        _param.Do();
        _param.Do1();
    }

    public override void Param(IType param)
    {
        _param = param as Foo1Request;
    }
}