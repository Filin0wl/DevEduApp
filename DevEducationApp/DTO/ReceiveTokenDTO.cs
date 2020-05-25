using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.DTO
{
     class ReceiveTokenDTO
    {
        [JsonProperty("userId")]
        public int UserId { get; set; }
        [JsonProperty("access_token")]
        public string Token { get; set; }

        [JsonProperty("username")]
        public string Login { get; set; }
    }
}
