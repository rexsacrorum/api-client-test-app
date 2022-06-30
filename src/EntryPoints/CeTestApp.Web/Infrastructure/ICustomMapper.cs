using CeTestApp.Domain.Dto;
using CeTestApp.Web.Domain.Contracts;

namespace CeTestApp.Web.Infrastructure;

/// <summary>
/// Used to map one object to another.
/// </summary>
public interface ICustomMapper
{
    List<OrderContract> ToOrdersContracts(List<OrderDto> orders);
    List<ProductContract> ToProductsContracts(List<ProductDto> products);
}