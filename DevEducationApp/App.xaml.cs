using Autofac;
using DevEducationApp.Containers.Manager;
using DevEducationApp.Services;
using DevEducationApp.ViewPage;
using System;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DevEducationApp
{
    public partial class App : Application
    {
        public static IContainer container;
        public App()
        {
            InitializeComponent();

            ContainerBuilder builder = new ContainerBuilder();
            RegisterTypes(builder);
            container = builder.Build();
            MainPage = new NavigationPage(new LoginPage());

        }

        private void RegisterTypes(ContainerBuilder builder)
        {
            builder.RegisterType<TokenManager>()
                .As<ITokenManager>()
                .SingleInstance();
            builder.Register<UserService>(c => new UserService())
                .As<IUserService>();
            builder.Register<GroupManager>(c => new GroupManager())
                .As<IGroupManager>();
                
        }
        protected override void OnStart()
        {
            
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
