using System.Text;
using CeTestApp.Application.Interfaces;
using CeTestApp.Console.Application;
using CeTestApp.Domain.Commands;
using CeTestApp.Domain.Dto;

namespace CeTestApp.Console;

public class ConsoleWorkflow : IConsoleWorkflow
{
    public ConsoleWorkflow(IMerchantWorkflow workflow)
    {
        Workflow = workflow;
    }

    public async Task<string> GetInProgressOrdersAsStringAsync()
    {
        var orders = await Workflow.GetOrdersInProgressAsync()
            .ConfigureAwait(false);

        var sb = new StringBuilder(orders.Count);
        foreach (var order in orders)
            sb.Append(order);

        return sb.ToString();
    }

    public async Task<string> GetTop5ProductsAsStringAsync()
    {
        var products = await Workflow.GetTop5ProductsAsync()
            .ConfigureAwait(false);

        var sb = new StringBuilder(products.Count);
        foreach (var product in products)
        {
            sb.Append(product);
        }

        return sb.ToString();
    }

    public async Task<SetProductStockResponse> SetStockTo25ToRandomProductAsync()
    {
        var products = await Workflow.GetTop5ProductsAsync()
            .ConfigureAwait(false);
        return await SetRandomProductStockTo25Async(products)
            .ConfigureAwait(false);
    }
    
    private async Task<SetProductStockResponse> SetRandomProductStockTo25Async(List<ProductDto> products)
    {
        var stockSize = 25;

        SetProductStockResponse response = null;

        var product = GetRandomProduct(products);
        if (product == null)
            return response;

        var setStockCommand = new SetProductStockCommand
        {
            MerchantProductNo = product.MerchantProductNo,
            Stock = stockSize
        };
        await Workflow.SetProductStockAsync(setStockCommand)
            .ConfigureAwait(false);

        return new SetProductStockResponse
        {
            MerchantProductNo = product.MerchantProductNo,
            Stock = stockSize
        };
    }

    private ProductDto GetRandomProduct(List<ProductDto> products)
    {
        if (products == null || products.Count == 0)
            return null;

        int index = new Random().Next(products.Count);
        return products[index];
    }

    private IMerchantWorkflow Workflow { get; set; }
}