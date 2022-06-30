namespace CeTestApp.RestClient;

public class GlobalConfiguration : Configuration
{
    static GlobalConfiguration()
    {
        Instance = new GlobalConfiguration();
    }
    
    /// <summary>
    /// Gets or sets the default Configuration.
    /// </summary>
    /// <value>Configuration.</value>
    public static IReadableConfiguration Instance
    {
        get { return _globalConfiguration; }
        set
        {
            lock (GlobalConfigSync)
            {
                _globalConfiguration = value;
            }
        }
    }
    
    private static readonly object GlobalConfigSync = new { };
    private static IReadableConfiguration _globalConfiguration;
}