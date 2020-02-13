using System.Runtime.Serialization;

namespace VkApi.Wrapper.Types.Utils
{
    ///<summary>
    /// Object type
    ///</summary>
    public enum UtilsDomainResolvedType
    {
        [EnumMember(Value = "user")]
        User,
        [EnumMember(Value = "group")]
        Group,
        [EnumMember(Value = "application")]
        Application,
        [EnumMember(Value = "page")]
        Page
    }
}