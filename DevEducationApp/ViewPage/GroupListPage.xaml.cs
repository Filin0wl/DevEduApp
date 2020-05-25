using Autofac;
using DevEducationApp.Containers.Manager;
using DevEducationApp.Models;
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
    public partial class GroupListPage : ContentPage
    {
        GroupsService groupsService = new GroupsService(new GroupDTORequester());
        public GroupListPage()
        {
            BindingContext = new GroupListViewModel(groupsService) { Navigation = this.Navigation };
            
            InitializeComponent();

        }

        private async void ListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            GroupModel tmp = (GroupModel)e.Item;
            App.container.Resolve<IGroupManager>().GroupId = 615;
            await this.Navigation.PushAsync(new GroupInfoPage());
        }
    }
}