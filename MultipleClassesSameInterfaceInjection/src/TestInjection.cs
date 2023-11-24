using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GeneralTesting.MultipleClassesSameInterfaceInjection;

public class TestInjection
{
    public void Inject()
    {
        var builder = Host.CreateApplicationBuilder(null);
        builder.Services.AddScoped<IClass<Class1>, Class1>();
        builder.Services.AddScoped<IClass<Class2>, Class2>();
        builder.Services.AddScoped<TestClass1>();
        builder.Services.AddScoped<TestClass2>();
        using var host = builder.Build();
        
        var class1 = host.Services.GetService<TestClass1>();
        class1.Do();
        
        var class2 = host.Services.GetService<TestClass2>();
        class2.Do();
    }

}