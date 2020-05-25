using Autofac;
using DevEducationApp.Containers.Manager;
using DevEducationApp.DTO;
using DevEducationApp.Requester;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DevEducationApp.Services
{
    public class GroupInfoService
    {
        private List<LessonDto> lessons;
        private GroupDto group;
        private readonly LessonDTORequester _requesterLessons;
        private readonly GroupDTORequester _requesterGroup;
        private int _groupId;
        public GroupInfoService(LessonDTORequester requesterLessons, GroupDTORequester requesterGroups)
        {
            _requesterLessons = requesterLessons;
            _requesterGroup = requesterGroups;
            var tmp = App.container.Resolve<IGroupManager>().GroupId;
            _groupId = 615;
        }

        public async Task<GroupDto> ReadGroupInfo()
        {
            if (group != null)
            {
                return group;
            }
            return await _requesterGroup.GroupById(_groupId).ConfigureAwait(false);
        }
        public async Task<ICollection<LessonDto>> ReadLessons()
        {

            if (lessons != null)
            {
                return lessons;
            }
            return await _requesterLessons.LessonsByGroup(_groupId).ConfigureAwait(false);
        }
    }
}
