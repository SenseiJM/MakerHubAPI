using MakerHubAPI.DTO.Club;
using MakerHubAPI.DTO.Member;
using MakerHubAPI.DTO.Season;
using MakerHubAPI.DTO.Team;
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

        public int GetCurrentSeason() {
            HttpResponseMessage message = _client.GetAsync("v1/seasons/current").Result;
            if(message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<SeasonDetailsDTO>(json).Season;
            }
            throw new HttpRequestException();
        }

        public IEnumerable<ClubIndexDTO> GetAllClubs(int seasonID) {
            _client.DefaultRequestHeaders.Add("X-TabT-Database", "aftt");
            _client.DefaultRequestHeaders.Add("X-Tabt-Season", seasonID.ToString());

            HttpResponseMessage message = _client.GetAsync("v1/clubs").Result;
            if(message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<ClubIndexDTO>>(json);
            }
            throw new HttpRequestException();
        }

        public ClubIndexDTO GetClubByIndex(string index, int seasonID) {
            _client.DefaultRequestHeaders.Add("X-TabT-Database", "aftt");
            _client.DefaultRequestHeaders.Add("X-Tabt-Season", seasonID.ToString());

            HttpResponseMessage message = _client.GetAsync("v1/clubs/" + index).Result;
            if (message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<ClubIndexDTO>(json);
            }
            throw new HttpRequestException();
        }

        public IEnumerable<MemberIndexDTO> GetMembers(int seasonID) {
            _client.DefaultRequestHeaders.Add("X-Tabt-Database", "aftt");
            _client.DefaultRequestHeaders.Add("X-Tabt-Season", seasonID.ToString());
            HttpResponseMessage message = _client.GetAsync("v1/clubs/N069/members").Result;
            if (message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<MemberIndexDTO>>(json);
            }
            throw new HttpRequestException();
        }

        public IEnumerable<TeamIndexDTO> GetTeams(int seasonID) {
            _client.DefaultRequestHeaders.Add("X-Tabt-Database", "aftt");
            HttpResponseMessage message = _client.GetAsync("v1/clubs/N069/teams?season=" + seasonID).Result;
            if (message.IsSuccessStatusCode) {
                string json = message.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<IEnumerable<TeamIndexDTO>>(json);
            }
            throw new HttpRequestException();
        }
    }
}
