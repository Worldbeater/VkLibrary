using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class UtilsGetLastShortenedLinksResponse
    {
        ///<summary>
        /// Total number of available results
        ///</summary>
        [JsonProperty("count")]
        public int Count { get; set; }
        [JsonProperty("items")]
        public UtilsLastShortenedLink[] Items { get; set; }
    }
}