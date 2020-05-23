using DevEducationApp.AdapterModels;
using DevEducationApp.DTO;
using DevEducationApp.Models;
using DevEducationApp.Requester;
using DevEducationApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DevEducationApp.ViewModel
{
    public class GroupsViewModel
    {
        private readonly GroupService _service;
        public ObservableCollection<GroupModel> Groups { get; set; }
        public Command LoadGroupCommand { get; set; }
        public GroupsViewModel(GroupService service)
        {
            Groups = new ObservableCollection<GroupModel>();
            LoadGroupCommand = new Command(async () => await ExecuteLoadGroupsCommand());
            _service = service;
        }

        private async Task ExecuteLoadGroupsCommand()
        {
            var groups = await _service.ReadGroups();
            Groups.Clear();
            groups.ForEach(group =>
            {
                GroupModel g = (GroupModel)GroupModelAdapter.Convert(group);
                Groups.Add(g);
            });
        }
    }
}
