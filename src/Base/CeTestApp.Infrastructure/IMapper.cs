using CeTestApp.Domain.Commands;
using CeTestApp.Domain.Dto;
using CeTestApp.MerchantClient.Api;
using CeTestApp.MerchantClient.Model;

namespace CeTestApp.Infrastructure;

public interface IMapper
{
    StockPriceUpdateRequest ToStockPriceUpdateRequest(SetProductStockCommand command);
    OrderDto ToOrderDto(OrderResponse response);
}