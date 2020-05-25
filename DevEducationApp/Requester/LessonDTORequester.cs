using Autofac;
using DevEducationApp.DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DevEducationApp.Requester
{
    public class LessonDTORequester
    {
        private HttpClient _httpClient;
        private readonly string Token;

        public LessonDTORequester()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };

            Token = App.container.Resolve<ITokenManager>().GetToken();
        }

        public async Task<ICollection<LessonDto>> LessonsByGroup(int groupId, CancellationToken cancellationToken = default(CancellationToken))
        {
            string tempId = groupId.ToString();
            _httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var resp = await _httpClient.GetAsync($"/api/Lesson/get-lesson-by-group/{tempId}", cancellationToken).ConfigureAwait(false);

            if (resp.StatusCode == HttpStatusCode.OK)
            {
                var respObj = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<List<LessonDto>>(respObj);
            }
            else
            {
                //TODO обработка если запрос фейлится 
                return default(ICollection<LessonDto>);
            }
        }

        //public async bool Get


    }
}
