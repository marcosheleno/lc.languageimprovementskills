using System.Reflection;
using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._3.Feature.FeatureFoo;
using GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1._4.Shared.SharedFoo;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GeneralTesting.MultipleClassesSameInterfaceBuiltByParam_1;

public class ConditionalInjection
{
    public void Inject()
    {
        var builder = Host.CreateApplicationBuilder(null);
        builder.Services.AddScoped<ServiceFoo, Foo1>();
        builder.Services.AddScoped<ServiceFoo, Foo2>();
        using var host = builder.Build();

        var foo1 = Build<Foo1, Foo1Request>(host.Services);
        foo1.Do();

        var foo2 = Build<Foo2, Foo2Request>(host.Services);
        foo2.Do();
    }

    private ServiceFoo Build<TService, TParam>(IServiceProvider services)
        where TService : ServiceFoo where TParam : IType
    {
        var service = services.GetServices<ServiceFoo>().First(n => n is TService) as ServiceFoo;
        var type = service.GetType().GetField("_param", BindingFlags.NonPublic | BindingFlags.Instance)!;
        var _param = (TParam)Activator.CreateInstance(type.FieldType)!;
        service.Param(_param);
        return service;
    }
}