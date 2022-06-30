using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CeTestApp.MerchantClient.Model;

/// <summary>
/// Defines Condition
/// </summary>
[JsonConverter(typeof (JsonStringEnumConverter))]
public enum Condition
{
    /// <summary>
    /// Enum NEW for value: NEW
    /// </summary>
    [EnumMember(Value = "NEW")]
    NEW = 1,

    /// <summary>
    /// Enum NEWREFURBISHED for value: NEW_REFURBISHED
    /// </summary>
    [EnumMember(Value = "NEW_REFURBISHED")]
    NEW_REFURBISHED = 2,

    /// <summary>
    /// Enum USEDASNEW for value: USED_AS_NEW
    /// </summary>
    [EnumMember(Value = "USED_AS_NEW")]
    USED_AS_NEW = 3,

    /// <summary>
    /// Enum USEDGOOD for value: USED_GOOD
    /// </summary>
    [EnumMember(Value = "USED_GOOD")]
    USED_GOOD = 4,

    /// <summary>
    /// Enum USEDREASONABLE for value: USED_REASONABLE
    /// </summary>
    [EnumMember(Value = "USED_REASONABLE")]
    USED_REASONABLE = 5,

    /// <summary>
    /// Enum USEDMEDIOCRE for value: USED_MEDIOCRE
    /// </summary>
    [EnumMember(Value = "USED_MEDIOCRE")]
    USED_MEDIOCRE = 6,

    /// <summary>
    /// Enum UNKNOWN for value: UNKNOWN
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    UNKNOWN = 7,

    /// <summary>
    /// Enum USEDVERYGOOD for value: USED_VERY_GOOD
    /// </summary>
    [EnumMember(Value = "USED_VERY_GOOD")]
    USED_VERY_GOOD = 8
}