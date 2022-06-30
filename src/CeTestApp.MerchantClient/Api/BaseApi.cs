using CeTestApp.RestClient;

namespace CeTestApp.MerchantClient.Api;

public abstract class BaseApi
{
    protected BaseApi(IApiClient client, IReadableConfiguration configuration)
    {
        Client = client;
        Configuration = configuration;
        ExceptionFactory = RestClient.Configuration.DefaultExceptionFactory;
    }
    
    protected RequestOptions GetRequestOptions()
    {
        var options = new RequestOptions();
        options.HeaderParameters.Add("Accept", "application/json");
        
        // authentication (apiKey) required
        if (!string.IsNullOrEmpty(Configuration.ApiKey))
            options.QueryParameters.Add(ClientUtils.ParameterToMultiMap("", "apikey", this.Configuration.ApiKey));

        return options;
    }
    
    protected ExceptionFactory ExceptionFactory = (name, response) => null;
    protected IReadableConfiguration Configuration { get; }
    protected IApiClient Client { get; }
}