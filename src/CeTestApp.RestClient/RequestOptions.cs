namespace CeTestApp.RestClient;

/// <summary>
/// A container for generalized request inputs. This type allows consumers to extend the request functionality
/// by abstracting away from the default (built-in) request framework (e.g. RestSharp).
/// </summary>
public class RequestOptions
{
    /// <summary>
    /// Header parameters to be applied to to the request.
    /// </summary>
    /// <remarks>
    /// Keys may have 1 or more values associated.
    /// </remarks>
    public Multimap<string, string> HeaderParameters { get; set; }
    /// <summary>
    /// Query parameters to be applied to the request.
    /// Keys may have 1 or more values associated.
    /// </summary>
    public Multimap<string, string> QueryParameters { get; set; }
    
    /// <summary>
    /// Any data associated with a request body.
    /// </summary>
    public Object Data { get; set; }
    
    public RequestOptions()
    {
        QueryParameters = new Multimap<string, string>();
        HeaderParameters = new Multimap<string, string>();
    }
}