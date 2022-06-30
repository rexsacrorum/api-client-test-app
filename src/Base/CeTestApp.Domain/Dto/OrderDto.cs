using System.Text;

namespace CeTestApp.Domain.Dto;

/// <summary>
///     Order dto.
/// </summary>
public class OrderDto
{
    /// <summary>
    ///     The unique identifier used by ChannelEngine.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    ///     The name of the channel for this specific environment/account.
    /// </summary>
    public string ChannelName { get; set; }

    /// <summary>
    ///     Order lines.
    /// </summary>
    public List<OrderLineDto> Lines { get; set; }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append(" Order {\n");
        sb.Append("  Id: ").Append(Id);
        sb.Append("  ChannelName: ").Append(ChannelName);
        sb.Append("  Lines: ");
        foreach (var line in Lines) sb.Append("\n").Append(line);
        sb.Append("\n} \n");
        return sb.ToString();
    }
}