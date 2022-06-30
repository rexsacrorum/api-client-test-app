// See https://aka.ms/new-console-template for more information

using CeTestApp.Application.Interfaces;
using CeTestApp.Console;
using CeTestApp.Console.Application;
using CeTestApp.Infrastructure.Workflows;
using CeTestApp.MerchantClient.Api;
using CeTestApp.RestClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

await Host.CreateDefaultBuilder(args).UseContentRoot(Directory.GetCurrentDirectory())
    .ConfigureAppConfiguration((hostingContext, config) =>
    {
        config.AddCommandLine(args);
        config.AddEnvironmentVariables();
        config.AddJsonFile("appsettings.json", false, true);
    }).ConfigureServices((hostContext, services) =>
    {
        services.AddSingleton<CommandLineArguments>(s => new CommandLineArguments(args));
        services.AddSingleton<IReadableConfiguration>(s => new Configuration
        {
            ApiKey = hostContext.Configuration.GetValue<string>("API_KEY")
                     ?? throw new ArgumentNullException("API_KEY"),
            BasePath = hostContext.Configuration.GetValue<string>("MERCHANT_API")
                       ?? throw new ArgumentNullException("MERCHANT_API")
        });
        services.AddHttpClient<IApiClient, ApiClient>();
        services
            .AddScoped<IOrderApi, OrderApi>()
            .AddScoped<IOfferApi, OfferApi>()
            .AddScoped<IMerchantWorkflow, MerchantWorkflow>()
            .AddScoped<IConsoleWorkflow, ConsoleWorkflow>();

        services.AddHostedService<ConsoleHostedService>();
    }).RunConsoleAsync();