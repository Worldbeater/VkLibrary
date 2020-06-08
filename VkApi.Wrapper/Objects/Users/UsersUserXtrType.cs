using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class UsersUserXtrType : UsersUser
    {
        [JsonProperty("type")]
        public UsersUserType Type { get; set; }
    }
}