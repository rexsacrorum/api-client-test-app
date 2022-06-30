using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Web;

namespace CeTestApp.RestClient;

public class ApiClient : IApiClient
{
    public ApiClient(HttpClient client)
    {
        Client = client;
    }

    public async Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration)
    {
        var request = NewRequest(HttpMethod.Get, path, options, configuration);

        return await ExecAsync<T>(request, configuration);
    }

    public async Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration)
    {
        var request = NewRequest(HttpMethod.Put, path, options, configuration);

        return await ExecAsync<T>(request, configuration).ConfigureAwait(false);
    }
    
    private async Task<ApiResponse<T>> ExecAsync<T>(HttpRequestMessage request, IReadableConfiguration configuration)
    {
        var response = await Client.SendAsync(request).ConfigureAwait(false);

        T data = await response.Content.ReadFromJsonAsync<T>().ConfigureAwait(false);
        
        return new ApiResponse<T>(response, data);
    }

    private HttpRequestMessage NewRequest(HttpMethod method,
        string path, 
        RequestOptions options,
        IReadableConfiguration configuration)
    {
        if (path == null)
            throw new ArgumentNullException(nameof(path));
        if (options == null)
            throw new ArgumentNullException(nameof(options));
        if (configuration == null)
            throw new ArgumentNullException(nameof(configuration));
        
        var request = new HttpRequestMessage
        {
            Method = method
        };

        if (options.HeaderParameters != null)
        {
            foreach (var headerParam in options.HeaderParameters)
                foreach (var value in headerParam.Value)
                    request.Headers.Add(headerParam.Key, value);
        }

        var builder = new UriBuilder(configuration.BasePath);
        builder.Path = builder.Path.TrimEnd('/') + '/' + path.TrimStart('/');

        var query = HttpUtility.ParseQueryString(builder.Query);
        if (options.QueryParameters != null)
        {
            foreach (var queryParam in options.QueryParameters)
                foreach (var value in queryParam.Value)
                    query.Add(queryParam.Key, value);
        }
        
        if (options.Data != null)
        {
            var json = JsonSerializer.Serialize(options.Data); 
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            request.Content = content;
        }

        builder.Query = query.ToString();

        request.RequestUri = builder.Uri;

        return request;
    }
    
    private HttpClient Client { get; }
}