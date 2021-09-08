using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;

namespace TranslationClient.Models
{

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
