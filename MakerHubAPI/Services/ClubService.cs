using MakerHubAPI.DTO.Club;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class ClubService {

        private readonly HttpClient _client;

        public ClubService(HttpClient client) {
            _client = client;
        }

        public IEnumerable<ClubIndexDTO> Get() {
            HttpResponseMessage message = _client.GetAsync("v1/clubs").Result;
            if(message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ClubIndexDTO>>(json);
            }
            throw new HttpRequestException();
        }
    }
}
