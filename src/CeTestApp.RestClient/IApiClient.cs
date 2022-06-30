namespace CeTestApp.RestClient;

/// <summary>
/// Contract for RESTful API interactions.
///
/// This interface allows consumers to provide a custom API accessor client.
/// </summary>
public interface IApiClient
{
    /// <summary>
    /// Executes a non-blocking call to some <paramref name="path"/> using the GET http verb.
    /// </summary>
    Task<ApiResponse<T>> GetAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration);

    /// <summary>
    /// Executes a non-blocking call to some <paramref name="path"/> using the PUT http verb.
    /// </summary>
    Task<ApiResponse<T>> PutAsync<T>(string path, RequestOptions options, IReadableConfiguration configuration);
}