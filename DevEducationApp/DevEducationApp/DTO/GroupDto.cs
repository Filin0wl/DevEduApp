using Newtonsoft.Json;
using System;

namespace DevEducationApp.DTO
{
    public class GroupDto :IDto
    {
        [JsonProperty("groupId", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public int? GroupId { get; set; }
        
        [JsonProperty("startDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? StartDate { get; set; }

        [JsonProperty("endtDate", Required = Required.DisallowNull, NullValueHandling = NullValueHandling.Ignore)]
        public DateTimeOffset? EndDate { get; set; }

        [JsonProperty("timeStartString", Required = Required.Default, NullValueHandling = NullValueHandling.Ignore)]
        public string TimeStartString { get; set; }
    }
}
