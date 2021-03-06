using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class NewsfeedNewsfeedPhoto : PhotosPhoto
    {
        [JsonProperty("likes")]
        public BaseLikes Likes { get; set; }
        [JsonProperty("comments")]
        public BaseObjectCount Comments { get; set; }

        ///<summary>
        /// Information whether current user can comment the photo
        ///</summary>
        [JsonProperty("can_comment")]
        public int CanComment { get; set; }

        ///<summary>
        /// Information whether current user can repost the photo
        ///</summary>
        [JsonProperty("can_repost")]
        public int CanRepost { get; set; }
    }
}