using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class WallPostResponse
    {
        ///<summary>
        /// Created post ID
        ///</summary>
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}