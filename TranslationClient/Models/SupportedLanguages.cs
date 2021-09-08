using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace TranslationClient.Models
{

    /// <summary>
    /// A common enumerator defining the supported languages
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SupportedLanguages
    {
        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "English")]
        English,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "French")]
        French,

        /// <summary>
        /// 
        /// </summary>
        [EnumMember(Value = "German")]
        German
    }
}
