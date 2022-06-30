using CeTestApp.MerchantClient.Model;
using CeTestApp.RestClient;

namespace CeTestApp.MerchantClient.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOfferApi
{
    /// <summary>
    /// Update stock and/or price.
    /// </summary>
    Task<OrderStockPriceUpdateResponse> OfferStockPriceUpdateAsync(List<StockPriceUpdateRequest> request);
    
    /// <summary>
    /// Update stock and/or price.
    /// </summary>
    Task<ApiResponse<OrderStockPriceUpdateResponse>> OfferStockPriceUpdateWithHttpInfoAsync(List<StockPriceUpdateRequest> request);
}