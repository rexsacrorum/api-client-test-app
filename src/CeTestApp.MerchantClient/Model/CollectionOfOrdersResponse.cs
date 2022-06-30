using System.Runtime.Serialization;
using System.Text;
using CeTestApp.MerchantClient.Model;

namespace CeTestApp.MerchantClient.Api;

public class CollectionOfOrdersResponse
{
    /// <summary>
    /// Gets or Sets Content
    /// </summary>
    [DataMember(Name = "Content", EmitDefaultValue = true)]
    public List<OrderResponse> Content { get; set; }
    
    /// <summary>
    /// Gets or Sets Count
    /// </summary>
    [DataMember(Name = "Count", EmitDefaultValue = false)]
    public int Count { get; set; }

    /// <summary>
    /// Gets or Sets TotalCount
    /// </summary>
    [DataMember(Name = "TotalCount", EmitDefaultValue = false)]
    public int TotalCount { get; set; }

    /// <summary>
    /// Gets or Sets ItemsPerPage
    /// </summary>
    [DataMember(Name = "ItemsPerPage", EmitDefaultValue = false)]
    public int ItemsPerPage { get; set; }

    /// <summary>
    /// Gets or Sets StatusCode
    /// </summary>
    [DataMember(Name = "StatusCode", EmitDefaultValue = false)]
    public int StatusCode { get; set; }

    /// <summary>
    /// Gets or Sets RequestId
    /// </summary>
    [DataMember(Name = "RequestId", EmitDefaultValue = true)]
    public string RequestId { get; set; }

    /// <summary>
    /// Gets or Sets LogId
    /// </summary>
    [DataMember(Name = "LogId", EmitDefaultValue = true)]
    public string LogId { get; set; }

    /// <summary>
    /// Gets or Sets Success
    /// </summary>
    [DataMember(Name = "Success", EmitDefaultValue = true)]
    public bool Success { get; set; }

    /// <summary>
    /// Gets or Sets Message
    /// </summary>
    [DataMember(Name = "Message", EmitDefaultValue = true)]
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets ValidationErrors
    /// </summary>
    [DataMember(Name = "ValidationErrors", EmitDefaultValue = true)]
    public Dictionary<string, List<string>> ValidationErrors { get; set; }
    
    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CollectionOfMerchantOrderResponse {\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
        sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
        sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
        sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
        sb.Append("  RequestId: ").Append(RequestId).Append("\n");
        sb.Append("  LogId: ").Append(LogId).Append("\n");
        sb.Append("  Success: ").Append(Success).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  ValidationErrors: ").Append(ValidationErrors).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }
}