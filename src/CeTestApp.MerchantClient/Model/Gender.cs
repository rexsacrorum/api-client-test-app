using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
/// Defines Gender
/// </summary>
[JsonConverter(typeof (JsonStringEnumConverter))]
public enum Gender
{
    /// <summary>
    /// Enum MALE for value: MALE
    /// </summary>
    [EnumMember(Value = "MALE")]
    MALE = 1,

    /// <summary>
    /// Enum FEMALE for value: FEMALE
    /// </summary>
    [EnumMember(Value = "FEMALE")]
    FEMALE = 2,

    /// <summary>
    /// Enum NOTAPPLICABLE for value: NOT_APPLICABLE
    /// </summary>
    [EnumMember(Value = "NOT_APPLICABLE")]
    NOT_APPLICABLE = 3
}