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
    public class GroupDTORequester
    {
        private HttpClient _httpClient;
        private readonly string Token;
        public GroupDTORequester()
        {
            _httpClient = new HttpClient()
            {
                BaseAddress = new Uri("http://80.78.240.16:5100/")
            };

            Token = App.container.Resolve<ITokenManager>().GetToken();
            //  DiContainer
        }
        public async Task<ICollection<GroupDto>> GroupByTeacher(int userId, CancellationToken cancellationToken = default(CancellationToken))
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var resp = await _httpClient.GetAsync($"/api/Group/groups-by-teacher-with-course-program/{userId}", cancellationToken).ConfigureAwait(false);

            if (resp.StatusCode == HttpStatusCode.OK)
            {
                var respObj = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<List<GroupDto>>(respObj);
            }
            else
            {
                //TODO обработка если запрос фейлится 
                return default(ICollection<GroupDto>);
            }
        }

        public async Task<GroupDto> GroupById(int groupId, CancellationToken cancellationToken = default(CancellationToken))
        {
            _httpClient.DefaultRequestHeaders.Accept.Add(MediaTypeWithQualityHeaderValue.Parse("text/plain"));
            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", Token);
            var resp = await _httpClient.GetAsync($"/api/Group/get/{groupId}", cancellationToken).ConfigureAwait(false);

            if (resp.StatusCode == HttpStatusCode.OK)
            {
                var respObj = await resp.Content.ReadAsStringAsync().ConfigureAwait(false);
                return JsonConvert.DeserializeObject<GroupDto>(respObj);
            }
            else
            {
                //TODO обработка если запрос фейлится 
                return default(GroupDto);
            }
        }
    }
}
