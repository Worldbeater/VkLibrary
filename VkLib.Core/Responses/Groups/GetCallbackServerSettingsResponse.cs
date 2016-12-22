using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Groups
{
    public class GetCallbackServerSettingsResponse
    {
        /// <summary>
        /// Server URL
        /// </summary>
        [JsonProperty("server_url")]
        public string ServerUrl { get; set; }

        /// <summary>
        /// Callback API secret key
        /// </summary>
        [JsonProperty("secret_key")]
        public string SecretKey { get; set; }

    }
}