using MakerHubAPI.DTO.Matches;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace MakerHubAPI.Services {
    public class MatchService {

        private readonly HttpClient _client;
        public MatchService(HttpClient client) {
            _client = client;
        }

        public IEnumerable<MatchDetailsDTO> GetMatchesByTeam(char teamLetter, int seasonID) {
            _client.DefaultRequestHeaders.Add("X-TabT-Database", "aftt");
            _client.DefaultRequestHeaders.Add("X-TabT-Season", seasonID.ToString());

            HttpResponseMessage message = _client.GetAsync("v1/matches?club=N069&team=" + teamLetter).Result;
            if (message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<MatchDetailsDTO>>(json);
            }
            throw new HttpRequestException();
        }
    }
}
