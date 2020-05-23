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

namespace DevEducationApp.Services
{
    public class UserService
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

        public async Task<string> Auth(LoginDTO model)
        {
            
                var authResult = await _client.Login(model);
                //if()
           


            /*HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Post, "token");
            request.Content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            HttpResponseMessage response = await _client.SendAsync(request);*/


           /* var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var respose = await _client.PostAsync("/token", content);
            var stringContent = await respose.Content.ReadAsStringAsync();
            var resultModel = JsonConvert.DeserializeObject<AuthResultModel>(stringContent);*/

            return authResult.Token;
        }
    }
}
