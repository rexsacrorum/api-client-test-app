namespace CeTestApp.RestClient;

public class Configuration : IReadableConfiguration
{
    public string BasePath { get; set; }
    
    public string ApiKey { get; set; }

    /// <summary>
    /// Gets the date time format used when serializing in the ApiClient
    /// </summary>
    public virtual string DateTimeFormat 
        => ISO8601_DATETIME_FORMAT;

    public int Timeout { get; }

    /// <summary>
    /// Default creation of exceptions for a given method name and response object
    /// </summary>
    public static readonly ExceptionFactory DefaultExceptionFactory = (methodName, response) =>
    {
        var status = (int)response.StatusCode;
        if (status >= 400)
        {
            return new ApiException(status, $"Error calling {methodName}");
        }
        return null;
    };

    /// <summary>
    /// Identifier for ISO 8601 DateTime Format
    /// </summary>
    /// <remarks>
    /// See https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8 for more information.
    /// </remarks>
    private const string ISO8601_DATETIME_FORMAT = "o";
}