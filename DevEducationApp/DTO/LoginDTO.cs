using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.DTO
{
     public class LoginDTO
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("password")]
        public string Password { get; set; }
        [JsonProperty("login")]
        public string Login { get; set; }
    }
}
