using System.Net;

namespace CeTestApp.RestClient;

public interface IApiResponse
{
    public HttpStatusCode StatusCode { get; }
}

public class ApiResponse<T> : IApiResponse
{
    public ApiResponse(HttpResponseMessage httpResponse, T data)
    {
        HttpResponse = httpResponse ?? throw new ArgumentNullException(nameof(httpResponse));
        Data = data;
    }

    public T Data { get; set; }
    public HttpStatusCode StatusCode 
        => HttpResponse.StatusCode;

    public HttpResponseMessage HttpResponse { get; }
}