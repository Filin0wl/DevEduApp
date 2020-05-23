using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.Models
{
    public class GroupModel : IModel
    {
        public int? GroupId { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string TimeStartString { get; set; }
    }
}
