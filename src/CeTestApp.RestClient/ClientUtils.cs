using System.Collections;
using System.Globalization;

namespace CeTestApp.RestClient;

public static class ClientUtils
{
    /// <summary>
    /// Convert params to key/value pairs.
    /// Use collectionFormat to properly format lists and collections.
    /// </summary>
    /// <param name="collectionFormat">The swagger-supported collection format, one of: csv, tsv, ssv, pipes, multi</param>
    /// <param name="name">Key name.</param>
    /// <param name="value">Value object.</param>
    /// <returns>A multimap of keys with 1..n associated values.</returns>
    public static Multimap<string, string> ParameterToMultiMap(string collectionFormat, string name, object value)
    {
        var parameters = new Multimap<string, string>();

        if (value is ICollection collection && collectionFormat == "multi")
        {
            foreach (var item in collection)
            {
                parameters.Add(name, ParameterToString(item));
            }
        }
        else if (value is IDictionary dictionary)
        {
            if(collectionFormat == "deepObject") {
                foreach (DictionaryEntry entry in dictionary)
                {
                    parameters.Add(name + "[" + entry.Key + "]", ParameterToString(entry.Value));
                }
            }
            else {
                foreach (DictionaryEntry entry in dictionary)
                {
                    parameters.Add(entry.Key.ToString(), ParameterToString(entry.Value));
                }
            }
        }
        else
        {
            parameters.Add(name, ParameterToString(value));
        }

        return parameters;
    }
    
    /// <summary>
    /// If parameter is DateTime, output in a formatted string (default ISO 8601), customizable with Configuration.DateTime.
    /// If parameter is a list, join the list with ",".
    /// Otherwise just return the string.
    /// </summary>
    /// <param name="obj">The parameter (header, path, query, form).</param>
    /// <param name="configuration">An optional configuration instance, providing formatting options used in processing.</param>
    /// <returns>Formatted string.</returns>
    public static string ParameterToString(object obj, IReadableConfiguration configuration = null)
    {
        if (obj is DateTime dateTime)
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return dateTime.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
        if (obj is DateTimeOffset dateTimeOffset)
            // Return a formatted date string - Can be customized with Configuration.DateTimeFormat
            // Defaults to an ISO 8601, using the known as a Round-trip date/time pattern ("o")
            // https://msdn.microsoft.com/en-us/library/az4se3k1(v=vs.110).aspx#Anchor_8
            // For example: 2009-06-15T13:45:30.0000000
            return dateTimeOffset.ToString((configuration ?? GlobalConfiguration.Instance).DateTimeFormat);
        if (obj is bool boolean)
            return boolean ? "true" : "false";
        if (obj is ICollection collection)
            return string.Join(",", collection.Cast<object>());

        return Convert.ToString(obj, CultureInfo.InvariantCulture);
    }
}