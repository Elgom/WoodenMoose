﻿using Newtonsoft.Json;
using System;

namespace WindowsStoreServices.OAuth
{
    public class OAuthToken
    {
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        [JsonProperty("expires_in")]
        [JsonConverter(typeof(SecondsToTimeSpanConverter))]
        public TimeSpan ExpiresIn { get; set; }
        //[JsonProperty("expires_on")]
        //public DateTime ExpiresOn { get; set; }
        //[JsonProperty("not_before")]
        //public DateTime NotBefore { get; set; }
        [JsonProperty("resource")]
        public string Resource { get; set; }
        [JsonProperty("token_type")]
        public string TokenType { get; set; }
    }
}
