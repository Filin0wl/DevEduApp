using DevEducationApp.AdapterModels;
using DevEducationApp.Models;
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
    public class GroupInfoViewModel
    {
        private readonly GroupInfoService _service;

        public INavigation Navigation { get; set; }

        public GroupModel GroupInfo { get; set; }
        public ObservableCollection<LessonModel> Lessons { get; set; }
        public Command LoadGroupInfoCommand { get; set; }
        public GroupInfoViewModel(GroupInfoService service)
        {
            Lessons = new ObservableCollection<LessonModel>();

            LoadGroupInfoCommand = new Command(async () => await ExecuteLoadGroupInfoCommand());
            _service = service;
            ExecuteLoadGroupInfoCommand();
        }

        private async Task ExecuteLoadGroupInfoCommand()
        {
            var lessons = await _service.ReadLessons();
            Lessons.Clear();
            lessons.ForEach(lesson =>
            {
                LessonModel l = LessonModelAdapter.Convert(lesson);
                Lessons.Add(l);
            });
        }


    }
}

