using DevEducationApp.Requester;
using DevEducationApp.Services;
using DevEducationApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevEducationApp.ViewPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupInfoPage : ContentPage
    {
        private readonly GroupInfoService groupsService = new GroupInfoService(new LessonDTORequester(),new GroupDTORequester());
        public GroupInfoPage()
        {
            BindingContext = new GroupInfoViewModel(groupsService) { Navigation = this.Navigation };
            InitializeComponent();
        }

        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }
    }
}