using CeTestApp.MerchantClient.Model;
using CeTestApp.RestClient;

namespace CeTestApp.MerchantClient.Api;

public class OfferApi : BaseApi, IOfferApi
{
    public OfferApi(IApiClient client, IReadableConfiguration configuration)
        : base(client, configuration)
    { }

    public async Task<OrderStockPriceUpdateResponse> OfferStockPriceUpdateAsync(List<StockPriceUpdateRequest> request)
    {
        var response = await OfferStockPriceUpdateWithHttpInfoAsync(request).ConfigureAwait(false);
        return response.Data;
    }

    public async Task<ApiResponse<OrderStockPriceUpdateResponse>> OfferStockPriceUpdateWithHttpInfoAsync(List<StockPriceUpdateRequest> request)
    {
        if (request == null)
            throw new ApiException(400,
                $"Missing required parameter '{nameof(request)}' when calling OfferApi->OfferStockPriceUpdate");

        var requestOptions = GetRequestOptions();

        requestOptions.Data = request;

        var response = await Client.PutAsync<OrderStockPriceUpdateResponse>("/v2/offer", requestOptions, Configuration)
            .ConfigureAwait(false);

        if (ExceptionFactory != null)
        {
            var exception = ExceptionFactory("OfferStockPriceUpdate", response);
            if (exception != null)
                throw exception;
        }

        return response;
    }
}