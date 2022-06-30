using CeTestApp.Application.Interfaces;
using CeTestApp.Domain.Dto;
using CeTestApp.Web.Application.Interfaces;
using CeTestApp.Web.Models;
using SetProductStockCommand = CeTestApp.Web.Domain.Contracts.SetProductStockCommand;

namespace CeTestApp.Web.Infrastructure.Workflows;

public class HomeWorkflow : IHomeWorkflow
{
    public HomeWorkflow(IMerchantWorkflow workflow, ICustomMapper mapper)
    {
        Workflow = workflow;
        Mapper = mapper;
    }

    private IMerchantWorkflow Workflow { get; }
    private ICustomMapper Mapper { get; }

    public async Task<Home> GetResultOfAllOperationsAsync()
    {
        var orders = await Workflow.GetOrdersInProgressAsync();
        var products = await Workflow.GetTop5ProductsAsync();
        var setProductStockContract = await SetRandomProductStockTo25Async(products);

        var model = new Home
        {
            OrdersInProgress = Mapper.ToOrdersContracts(orders),
            Top5Products = Mapper.ToProductsContracts(products),
            SetProductStockCommand = setProductStockContract
        };

        return model;
    }

    private async Task<SetProductStockCommand> SetRandomProductStockTo25Async(List<ProductDto> products)
    {
        var stockSize = 25;

        SetProductStockCommand command = null;

        var product = GetRandomProduct(products);
        if (product == null)
            return command;

        var setStockCommand = new CeTestApp.Domain.Commands.SetProductStockCommand
        {
            MerchantProductNo = product.MerchantProductNo,
            Stock = stockSize
        };
        await Workflow.SetProductStockAsync(setStockCommand);

        return new SetProductStockCommand
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
}