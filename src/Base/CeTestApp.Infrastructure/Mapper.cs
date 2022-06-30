using CeTestApp.Domain.Commands;
using CeTestApp.Domain.Dto;
using CeTestApp.MerchantClient.Api;
using CeTestApp.MerchantClient.Model;

namespace CeTestApp.Infrastructure;

public class Mapper : IMapper
{
    public StockPriceUpdateRequest ToStockPriceUpdateRequest(SetProductStockCommand command)
        => new()
        {
            MerchantProductNo = command.MerchantProductNo,
            Stock = command.Stock
        };

    public OrderDto ToOrderDto(OrderResponse response)
        => new()
        {
            Id = response.Id,
            ChannelName = response.ChannelName,
            Lines = response.Lines
                .Select(ToOrderLineDto)
                .ToList()
        };

    private OrderLineDto ToOrderLineDto(OrderLineResponse line)
        => new()
        {
            Description = line.Description,
            Gtin = line.Description,
            MerchantProductNo = line.MerchantProductNo,
            Quantity = line.Quantity
        };
}
