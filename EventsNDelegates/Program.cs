using EventsNDelegates.Contracts;
using EventsNDelegates.DelegateHandlers;
using EventsNDelegates.Service;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(null);
builder.Services.AddScoped<DispatchEvent>();
builder.Services.AddScoped<IWriterDelegate, WriteAddressDelegate>();
builder.Services.AddScoped<IWriterDelegate, WriteAgeDelegate>();
builder.Services.AddScoped<IWriterDelegate, WriteNameDelegate>();
using var host = builder.Build();

var service = host.Services.GetService<DispatchEvent>()!;
service.Init();
service.Dispatch();