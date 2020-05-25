using DevEducationApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;
using System.Net.Http.Headers;
using DevEducationApp.DTO;
using Autofac;

namespace DevEducationApp.Services
{
    public class UserService : IUserService
    {
        private readonly IUserApi _client;
        
        public UserService()
        {
            HttpClient client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };
            _client = RestService.For<IUserApi>(client);

           // _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task Auth(LoginDTO model)
        {
            
            var authResult = await _client.Login(model);
            if(authResult.Token != null)
            {
                App.container.Resolve<ITokenManager>().SetToken(authResult.Token);
                App.container.Resolve<ITokenManager>().UserId = authResult.UserId;
            }

            
        }
    }
}
