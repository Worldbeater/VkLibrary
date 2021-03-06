using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class PhotosMarketAlbumUploadResponse
    {
        ///<summary>
        /// Community ID
        ///</summary>
        [JsonProperty("gid")]
        public int Gid { get; set; }

        ///<summary>
        /// Uploading hash
        ///</summary>
        [JsonProperty("hash")]
        public String Hash { get; set; }

        ///<summary>
        /// Uploaded photo data
        ///</summary>
        [JsonProperty("photo")]
        public String Photo { get; set; }

        ///<summary>
        /// Upload server number
        ///</summary>
        [JsonProperty("server")]
        public int Server { get; set; }
    }
}