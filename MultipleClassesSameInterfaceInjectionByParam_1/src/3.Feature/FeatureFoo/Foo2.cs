using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._4.Shared.SharedFoo;

namespace GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._3.Feature.FeatureFoo;

public class Foo2: ServiceFoo
{
    private Foo2Request _param;
    public override void Do()
    {
        Console.WriteLine("foo 2");
        _param.Do();
        _param.Do2();
    }

    public override void Param(IType param)
    {
        _param = param as Foo2Request;
    }
}