using Newtonsoft.Json;
using VkApi.Wrapper.Objects;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace VkApi.Wrapper.Responses
{
    public class GroupsGetTokenPermissionsResponse
    {
        [JsonProperty("mask")]
        public int Mask { get; set; }
        [JsonProperty("permissions")]
        public GroupsTokenPermissionSetting[] Permissions { get; set; }
    }
}