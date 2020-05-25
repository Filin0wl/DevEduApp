using DevEducationApp.DTO;
using DevEducationApp.Requester;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Refit;
using Autofac;

namespace DevEducationApp.Services
{
    public class GroupsService
    {
        private List<GroupDto> groups;
        private readonly GroupDTORequester requester;
        private  int _userId;
        public GroupsService(GroupDTORequester requester)
        {
            this.requester = requester;
            var tmp = App.container.Resolve<ITokenManager>().UserId;
            _userId = tmp;
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
