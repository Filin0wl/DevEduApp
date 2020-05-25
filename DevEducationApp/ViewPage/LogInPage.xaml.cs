using Autofac;
using DevEducationApp.DTO;
using DevEducationApp.Models;
using DevEducationApp.Requester;
using DevEducationApp.Services;
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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void logInBtn_Clicked(object sender, EventArgs e)
        {

            Start();

        }

        private async void Start()
        {
            await App.container.Resolve<IUserService>().Auth(new DTO.LoginDTO()
            {
                Password = EntryPassword.Text,
                Login = EntryLogin.Text
            });

            await Navigation.PushAsync(new GroupListPage());
        }
    }
}