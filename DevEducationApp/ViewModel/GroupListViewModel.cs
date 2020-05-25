using DevEducationApp.AdapterModels;
using DevEducationApp.DTO;
using DevEducationApp.Models;
using DevEducationApp.Requester;
using DevEducationApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace DevEducationApp.ViewModel
{
    public class GroupListViewModel 
    {
        private readonly GroupsService _service;

        public INavigation Navigation { get; set; }

        public ObservableCollection<GroupModel> Groups { get; set; }
        public Command LoadGroupCommand { get; set; }
        public GroupListViewModel(GroupsService service)
        {
            Groups = new ObservableCollection<GroupModel>();
            
            LoadGroupCommand = new Command(async () => await ExecuteLoadGroupsCommand());
            _service = service;
            ExecuteLoadGroupsCommand();
        }

        private async Task ExecuteLoadGroupsCommand()
        {
            var groups = await _service.ReadGroups();
            Groups.Clear();
            groups.ForEach(group =>
            {
                GroupModel g = GroupModelAdapter.Convert(group);
                Groups.Add(g);
            });
        }

        
    }
}
