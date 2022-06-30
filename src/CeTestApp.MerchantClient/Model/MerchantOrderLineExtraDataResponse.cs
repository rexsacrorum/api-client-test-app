using System.Runtime.Serialization;
using System.Text;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
/// MerchantOrderLineExtraDataResponse
/// </summary>
[DataContract(Name = "MerchantOrderLineExtraDataResponse")]
public class MerchantOrderLineExtraDataResponse
{
    /// <summary>
    /// Gets or Sets Key
    /// </summary>
    [DataMember(Name = "Key", EmitDefaultValue = true)]
    public string Key { get; set; }

    /// <summary>
    /// Gets or Sets Value
    /// </summary>
    [DataMember(Name = "Value", EmitDefaultValue = true)]
    public string Value { get; set; }
    
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MerchantOrderLineExtraDataResponse {\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}