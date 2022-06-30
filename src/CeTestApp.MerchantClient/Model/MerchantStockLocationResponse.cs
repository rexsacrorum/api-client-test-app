using System.Runtime.Serialization;
using System.Text;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
/// MerchantStockLocationResponse
/// </summary>
[DataContract(Name = "MerchantStockLocationResponse")]
public class MerchantStockLocationResponse
{
    /// <summary>
    /// The ChannelEngine id of the stock location.
    /// </summary>
    /// <value>The ChannelEngine id of the stock location.</value>
    [DataMember(Name = "Id", EmitDefaultValue = false)]
    public int Id { get; set; }

    /// <summary>
    /// The ChannelEngine name of the stock location.
    /// </summary>
    /// <value>The ChannelEngine name of the stock location.</value>
    [DataMember(Name = "Name", EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MerchantStockLocationResponse {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}