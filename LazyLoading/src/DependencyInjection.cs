using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;
using LazyLoading.Classes;
using LazyLoading.Contracts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace LazyLoading;

public class DependencyInjection
{
    [Benchmark]
    public void Lazy()
    {
        var builder = Host.CreateApplicationBuilder(null);
        builder.Services.AddScoped<LazyLoading>();
        builder.Services.AddScoped<IClass1, Class1>();
        builder.Services.AddScoped<Class2>();
        builder.Services.AddScoped<IClass3, Class3>();
        builder.Services.AddTransient(typeof(Lazy<>), typeof(LazyServiceProvider<>));
        using var host = builder.Build();

        var service = host.Services.GetService<LazyLoading>();
        service.Do();
    }
    
    [Benchmark]
    public void Normal()
    {
        var builder = Host.CreateApplicationBuilder(null);
        builder.Services.AddScoped<NormalInjection>();
        builder.Services.AddScoped<Class1>();
        builder.Services.AddScoped<Class2>();
        builder.Services.AddScoped<Class3>();
        using var host = builder.Build();

        var service = host.Services.GetService<NormalInjection>();
        service.Do();
    }
}

public class LazyServiceProvider<T> : Lazy<T>
    where T : class
{
    public LazyServiceProvider(IServiceProvider provider)
        : base(() => provider.GetRequiredService<T>())
    {
    }
}