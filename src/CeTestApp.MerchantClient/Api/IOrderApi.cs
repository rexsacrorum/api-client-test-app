using CeTestApp.RestClient;

namespace CeTestApp.MerchantClient.Api;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IOrderApi
{
    /// <summary>
    /// Get Orders By Filter.
    /// </summary>
    Task<CollectionOfOrdersResponse> OrderGetByFilterAsync(OrderGetByFilterRequest request);

    /// <summary>
    /// Get Orders By Filter.
    /// </summary>
    Task<ApiResponse<CollectionOfOrdersResponse>> OrderGetByFilterWithHttpInfoAsync(OrderGetByFilterRequest request);
}