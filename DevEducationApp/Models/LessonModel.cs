using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.Models
{
    public class LessonModel
    {
        public int Id { get; set; }
        public int GroupId { get; set; }
        public string Date { get; set; }
        public string HomeTask { get; set; }
        public string Videos { get; set; }
        public string ToRead { get; set; }
    }
}
