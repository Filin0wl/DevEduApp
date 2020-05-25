using DevEducationApp.DTO;
using DevEducationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.AdapterModels
{
    public class LessonModelAdapter
    {
        public static LessonModel Convert(LessonDto input)
        {
            LessonModel output = new LessonModel();
            output.Id = input.Id.HasValue ? input.Id.Value : 0;
            output.GroupId = input.GroupId.HasValue ? input.GroupId.Value : 0;
            output.Date = input.Date;
            output.HomeTask = input.Hometask;
            output.Videos = input.Videos;
            output.ToRead = input.toRead;
            return output;

        }
    }
}
