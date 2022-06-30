using CeTestApp.Console.Application;
using Microsoft.Extensions.Hosting;

namespace CeTestApp.Console;

public class ConsoleHostedService : IHostedService
{
    public ConsoleHostedService(IConsoleWorkflow workflow,
        CommandLineArguments cmdArgs, IHostApplicationLifetime applicationLifetime)
    {
        ApplicationLifetime = applicationLifetime;
        Workflow = workflow;
        CmdArgs = cmdArgs;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
        switch (CmdArgs.Command)
        {
            case Command.GetOrders:
                System.Console.WriteLine("### Orders in 'IN_PROGRESS' status.");
                System.Console.WriteLine(await Workflow.GetInProgressOrdersAsStringAsync());
                break;
            case Command.GetProducts:
                System.Console.WriteLine("### Top 5 products");
                System.Console.WriteLine(await Workflow.GetTop5ProductsAsStringAsync());
                
                break;
            case Command.SetStock:
                System.Console.WriteLine("### Set stock size for random product.");
                var response = await Workflow.SetStockTo25ToRandomProductAsync();
                if (response != null)
                    System.Console.WriteLine($"Stock of product with #'{response.MerchantProductNo}' was set to '{response.Stock}'");
                else
                    System.Console.WriteLine("There are no products.");

                break;
            default:
                throw new ArgumentException($"Unknown command '${CmdArgs.Command}'.", nameof(CmdArgs.Command));
                
        }
        
        ApplicationLifetime.StopApplication();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        return Task.CompletedTask;
    }
    
    private IConsoleWorkflow Workflow { get; set; }
    private CommandLineArguments CmdArgs { get; set; }
    private IHostApplicationLifetime ApplicationLifetime { get; }
}