using DevEducationApp.DTO;
using DevEducationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.AdapterModels
{
    public class GroupModelAdapter
    {
        public static GroupModel Convert(GroupDto input)
        {
            GroupModel output = new GroupModel();
            output.GroupId = input.GroupId.HasValue ? input.GroupId.Value : 0;
            output.StartDate = input.StartDate.HasValue ? input.StartDate.Value.ToString("dd/MM/yyyy") : default;
            output.EndDate = input.EndDate.HasValue ? input.EndDate.Value.ToString("dd/MM/yyyy") : default;
            output.TimeStartString = input.TimeStartString;
            output.Title = input.Title;
            return output;
        }
    }
}
