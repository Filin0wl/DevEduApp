using DevEducationApp.DTO;
using DevEducationApp.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DevEducationApp.AdapterModels
{
    public class GroupModelAdapter
    {
        public static IModel Convert(IDto input)
        {
            IModel output = new GroupModel();
            ((GroupModel)output).GroupId = ((GroupDto)input).GroupId.HasValue ? ((GroupDto)input).GroupId.Value : 0;
            ((GroupModel)output).StartDate = ((GroupDto)input).StartDate.HasValue ? ((GroupDto)input).StartDate.Value.ToString("dd/MM/yyyy") : default;
            ((GroupModel)output).EndDate = ((GroupDto)input).EndDate.HasValue ? ((GroupDto)input).EndDate.Value.ToString("dd/MM/yyyy") : default;
            ((GroupModel)output).TimeStartString = ((GroupDto)input).TimeStartString;

            return output;
        }
    }
}
