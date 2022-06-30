using CeTestApp.Domain.Dto;
using CeTestApp.Web.Domain.Contracts;

namespace CeTestApp.Web.Infrastructure;

public class CustomMapper : ICustomMapper
{
    public List<OrderContract> ToOrdersContracts(List<OrderDto> orders)
        => orders.Select(ToOrderContract).ToList();

    private OrderContract ToOrderContract(OrderDto dto)
        => new()
        {
            Id = dto.Id,
            ChannelName = dto.ChannelName,
            Lines = dto.Lines.Select(ToOrderLiceContract).ToList()
        };

    private OrderLineContract ToOrderLiceContract(OrderLineDto dto)
        => new()
        {
            Description = dto.Description,
            Gtin = dto.Gtin,
            Quantity = dto.Quantity,
        };

    public List<ProductContract> ToProductsContracts(List<ProductDto> products)
        => products.Select(ToProductContract).ToList();

    private ProductContract ToProductContract(ProductDto dto)
        => new()
        {
            Gtin = dto.Gtin,
            Name = dto.Name,
            Quantity = dto.Quantity
        };
}