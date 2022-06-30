using CeTestApp.RestClient;

namespace CeTestApp.MerchantClient.Api;

public class OrderApi : BaseApi, IOrderApi
{
    public OrderApi(IApiClient client, IReadableConfiguration configuration)
        : base(client, configuration)
    { }

    public async Task<CollectionOfOrdersResponse> OrderGetByFilterAsync(OrderGetByFilterRequest request)
    {
        var response = await OrderGetByFilterWithHttpInfoAsync(request).ConfigureAwait(false);
        return response.Data;
    }

    public async Task<ApiResponse<CollectionOfOrdersResponse>> OrderGetByFilterWithHttpInfoAsync(OrderGetByFilterRequest request)
    {
        var requestOptions = GetRequestOptions();
        
        if (request.Statuses != null)
            requestOptions.QueryParameters
                .Add(ClientUtils.ParameterToMultiMap("multi", "statuses", request.Statuses));

        var response = await Client.GetAsync<CollectionOfOrdersResponse>("/v2/orders", requestOptions, Configuration)
            .ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var exception = ExceptionFactory("OrderGetByFilterAsync", response);
            if (exception != null)
                throw exception;
        }
        
        return response;
    }
}