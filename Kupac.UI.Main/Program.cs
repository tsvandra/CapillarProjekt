using Kupac.Services.CustomerService;
using Kupac.Services.Interfaces;
using Kupac.UI.Customers;
using Microsoft.Extensions.DependencyInjection;
using Kupac.Data.DbContexts;

namespace Kupac.UI.Main;

static class Program
{
    // Dependency Injection Service Provider
    private static ServiceProvider _serviceProvider;
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        // 1. Build the service collection
        var services = new ServiceCollection();
        ConfigureServices(services);

        // 2. Build the service provider
        _serviceProvider = services.BuildServiceProvider();

        // 3. Start the application with the LoginForm
        var loginForm = _serviceProvider.GetRequiredService<LoginForm>();


        Application.Run(loginForm);

    }

    private static void ConfigureServices(IServiceCollection services)
    {
        // Register services
        services.AddScoped<ICustomerService, CustomerService>();

        // Register forms
        services.AddTransient<LoginForm>();
        services.AddTransient<CustomerEditorForm>();
        services.AddSingleton<CapillarContextFactory>();
    }
}