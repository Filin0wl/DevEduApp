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
            var service = new UserService();
            var model = new LoginDTO
            {
                Id = 0,
                Login = "TestYourLuck",
                Password = "123"
            };
            var tokenManager = new TokenManager();
            /*            var token = await service.Auth(model);*/
            var token = await service.Auth(model);
            tokenManager.SetToken(token);
            var groupService = new GroupDTORequester(token);

         //   var group = await groupService.GroupByTeacher();
        }
    }
}