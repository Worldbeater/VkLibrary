﻿using Newtonsoft.Json;
using VkLibrary.Core.Objects;

namespace VkApi.Wrapper.LongPolling.Bot.LongPollResponse
{
    public class PhotoCommentResponse : PhotosPhoto
    {
        [JsonProperty("photo_id")]
        public int PhotoId { get; set; }

        [JsonProperty("photo_owner_id")]
        public int PhotoOwnerId { get; set; }
    }
}