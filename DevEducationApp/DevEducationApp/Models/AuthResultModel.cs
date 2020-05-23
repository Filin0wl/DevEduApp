﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.Models
{
    class AuthResultModel
    {
        [JsonProperty("userId")]
        public int Id { get; set; }
        [JsonProperty("access_token")]
        public string Token { get; set; }
        
        [JsonProperty("username")]
        public string Login { get; set; }
    }
}
