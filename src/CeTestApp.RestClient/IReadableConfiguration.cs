namespace CeTestApp.RestClient;

public interface IReadableConfiguration
{
    /// <summary>
    /// Gets the base path.
    /// </summary>
    /// <value>Base path.</value>
    string BasePath { get; }
    
    string ApiKey { get; }
    
    /// <summary>
    /// Gets the date time format.
    /// </summary>
    /// <value>Date time format.</value>
    string DateTimeFormat { get; }
}