using System.Collections.Concurrent;
using CeTestApp.Domain.Dto;
using ChannelEngine.Merchant.ApiClient.Api;
using ChannelEngine.Merchant.ApiClient.Client;
using ChannelEngine.Merchant.ApiClient.Model;

namespace CeTestApp.Debug;

public class MerchantClientAdapter
{
    public MerchantClientAdapter()
    {
        OrderClient = new OrderApi(GetConfig());
        OfferApi = new OfferApi(GetConfig());
    }

    public async Task<string> GetAllOrdersAsJsonAsync()
    {
        // var response = await OrderClient.OrderGetByFilterAsync(new List<OrderStatusView>());
        var response = await OrderClient.OrderGetByFilterWithHttpInfoAsync(new List<OrderStatusView>());
        return response.RawContent;
    }

    public async Task<List<MerchantOrderResponse>> GetInProgressOrdersAsync()
    {
        var statuses = new List<OrderStatusView> { OrderStatusView.IN_PROGRESS };
        
        var response = await OrderClient.OrderGetByFilterAsync(statuses);
        if (!response.Success)
            throw new Exception("Request failed");

        return response.Content;
    }

    public async Task<List<ProductDto>> GetTop5ProductsAsync()
    {
        var orders = await GetInProgressOrdersAsync();
        
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

    public async Task SetProductStockAsync(string ProductNo, int stock)
    {
        var request2 = new List<MerchantStockPriceUpdateRequest>()
        {
            new ()
            {
                MerchantProductNo = ProductNo,
                Stock = stock
            }
        };

        var response = await OfferApi.OfferStockPriceUpdateAsync(request2);

        if (!response.Success)
            throw new Exception("Stock update failed");
    }

    private Configuration GetConfig()
    {
        var conf =  new Configuration()
        {
            BasePath = "https://api-dev.channelengine.net/api/",
            ApiKey = new ConcurrentDictionary<string, string>()
        };
        conf.ApiKey.Add("apikey", "541b989ef78ccb1bad630ea5b85c6ebff9ca3322");
        
        return conf;
    }
    
    private IOrderApiAsync OrderClient { get; set; }
    private IOfferApiAsync OfferApi { get; set; }
}