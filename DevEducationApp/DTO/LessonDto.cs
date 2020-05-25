using Newtonsoft.Json;
using System;


namespace DevEducationApp.DTO
{
    public class LessonDto
    {

        [JsonProperty("id")]
        public int? Id { get; set; }

        [JsonProperty("groupId")]
        public int? GroupId { get; set; }

        [JsonProperty("date")]
        public string Date { get; set; }

        [JsonProperty("hometask")]
        public string Hometask { get; set; }

        [JsonProperty("videos")]
        public string Videos { get; set; }

        [JsonProperty("toRead")]
        public string toRead { get; set; }
    }
}



