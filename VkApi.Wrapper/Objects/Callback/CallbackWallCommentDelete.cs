using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class CallbackWallCommentDelete
    {
        [JsonProperty("owner_id")]
        public int OwnerId { get; set; }
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("user_id")]
        public int UserId { get; set; }
        [JsonProperty("post_id")]
        public int PostId { get; set; }
    }
}