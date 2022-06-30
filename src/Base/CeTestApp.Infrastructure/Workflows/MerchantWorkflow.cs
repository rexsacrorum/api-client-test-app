using CeTestApp.Application.Interfaces;
using CeTestApp.Domain.Commands;
using CeTestApp.Domain.Dto;
using CeTestApp.MerchantClient.Api;

namespace CeTestApp.Infrastructure.Workflows;

public class MerchantWorkflow : IMerchantWorkflow
{
    public MerchantWorkflow(IOfferApi offerApi, IOrderApi orderApi)
        : this(offerApi, orderApi, new Mapper())
    { }
    
    public MerchantWorkflow(IOfferApi offerApi, IOrderApi orderApi, IMapper mapper)
    {
        OfferApi = offerApi;
        OrderApi = orderApi;
        Mapper = mapper;
    }

    public async Task<List<OrderDto>> GetOrdersInProgressAsync()
    {
        var response = await GetInProgressOrdersResponseAsync()
            .ConfigureAwait(false);
        
        return response.Content
            .Select(response => Mapper.ToOrderDto(response))
            .ToList();
    }

    public async Task<List<ProductDto>> GetTop5ProductsAsync()
    {
        var response = await GetInProgressOrdersResponseAsync()
            .ConfigureAwait(false);
        
        var orders = response.Content; 
        
        return orders.SelectMany(s => s.Lines)
            .Select(l => new
            {
                Gtin = l.Gtin,
                Name = l.Description,
                Quantity = l.Quantity,
                SKU = l.MerchantProductNo,
            }).GroupBy(o => o.SKU)
            .Select(g => new ProductDto
            {
                MerchantProductNo = g.Key,
                Gtin = g.First().Gtin,
                Name = g.First().Name,
                Quantity = g.Sum(s => s.Quantity)
            })
            .OrderByDescending(o => o.Quantity)
            .Take(5)
            .ToList();
    }

    public async Task SetProductStockAsync(SetProductStockCommand command)
    {
        var request = new List<StockPriceUpdateRequest>(1);
        var updateRequest = Mapper.ToStockPriceUpdateRequest(command);
        request.Add(updateRequest);

        await OfferApi.OfferStockPriceUpdateAsync(request).ConfigureAwait(false);
    }
    
    private async Task<CollectionOfOrdersResponse> GetInProgressOrdersResponseAsync()
    {
        var request = new OrderGetByFilterRequest
        {
            Statuses = new List<OrderStatus> { OrderStatus.IN_PROGRESS }
        };
        return await OrderApi.OrderGetByFilterAsync(request).ConfigureAwait(false);
    }
    
    private IOfferApi OfferApi { get; }
    private IOrderApi OrderApi { get; }
    private IMapper Mapper { get; }
}