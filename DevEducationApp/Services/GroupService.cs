using DevEducationApp.DTO;
using DevEducationApp.Requester;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationApp.Services
{
    public class GroupService
    {
        private List<GroupDto> groups;
        private readonly GroupDTORequester requester;
        private readonly int _userId;
        public GroupService(GroupDTORequester requester)
        {
            this.requester = requester;
            //var tmp DiContainer.Resolve
           // _userId = tmp.HasValue ? tmp.Value : 0;
        }

        public async Task<ICollection<GroupDto>> ReadGroups()
        {
            if(groups != null)
            {
                return groups;
            }
            return await requester.GroupByTeacher(_userId).ConfigureAwait(false);
        }
    }
}
