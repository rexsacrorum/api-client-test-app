using CeTestApp.Domain.Commands;
using CeTestApp.Domain.Dto;

namespace CeTestApp.Application.Interfaces;

/// <summary>
/// Business logic that was required in test app.
/// </summary>
public interface IMerchantWorkflow
{
    /// <summary>
    /// Returns orders in 'IN_PROGRESS' status.
    /// </summary>
    public Task<List<OrderDto>> GetOrdersInProgressAsync();

    /// <summary>
    /// Returns top 5 products. Ordered by the total quantity sold in descending order.
    /// </summary>
    public Task<List<ProductDto>> GetTop5ProductsAsync();

    
    /// <summary>
    /// Sets stock size for product.
    /// </summary>
    public Task SetProductStockAsync(SetProductStockCommand command);
}

