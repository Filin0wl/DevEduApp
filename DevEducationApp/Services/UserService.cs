using DevEducationApp.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Refit;

namespace DevEducationApp.Services
{
    public class UserService
    {
        private HttpClient _client;

        public UserService()
        {
            _client = new HttpClient
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };
        }

        public async Task<string> Auth(AccountModel model)
        {
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var respose = await _client.PostAsync("/token", content);
            var stringContent = await respose.Content.ReadAsStringAsync();
            var resultModel = JsonConvert.DeserializeObject<AuthResultModel>(stringContent);

            return resultModel.Token;
        }
    }
}
