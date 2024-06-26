﻿using Newtonsoft.Json;

namespace Pipedrive.CustomFields
{
    public class UserCustomField : ICustomField
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("has_pic")]
        public bool HasPic { get; set; }

        [JsonProperty("pic_hash")]
        public string PicHash { get; set; }

        [JsonProperty("active_flag")]
        public bool ActiveFlag { get; set; }

        [JsonProperty("value")]
        public long Value { get; set; }

        public override string ToString()
        {
            return $"{Name}, <{Email}>";
        }
    }
}
