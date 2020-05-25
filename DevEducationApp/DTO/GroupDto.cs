using Newtonsoft.Json;
using System;

namespace DevEducationApp.DTO
{
    public class GroupDto : IDto
    {
        [JsonProperty("groupId")]
        public int? GroupId { get; set; }

        [JsonProperty("startDate")]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endtDate")]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("timeStartString")]
        public string TimeStartString { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
