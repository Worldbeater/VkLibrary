using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace VkApi.Wrapper.Objects
{
    public class GroupsSubjectItem
    {
        ///<summary>
        /// Subject ID
        ///</summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        ///<summary>
        /// Subject title
        ///</summary>
        [JsonProperty("name")]
        public String Name { get; set; }
    }
}