using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NotificationsSendMessageError
    {
        ///<summary>
        /// Error code
        ///</summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        ///<summary>
        /// Error description
        ///</summary>
        [JsonProperty("description")]
        public String Description { get; set; }
    }
}