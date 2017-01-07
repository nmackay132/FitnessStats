using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using FitnessStats.Models;
using FitnessStats.Repositories;
using Newtonsoft.Json;

namespace FitnessStats.Services
{
    public class RunkeeperService
    {
        private HttpClient client;
        private const string RunkeeperToken = "1c349751b3de41d1ada3efc27becff7d";
        private SyncSettingsRepository syncSettingsRepository;

        public RunkeeperService()
        {
            syncSettingsRepository = new SyncSettingsRepository();
            SetUpHttpClient();
        }

        public List<Run> GetAllRunsIfChanges()
        {
            var response = client.GetAsync("fitnessActivities?pageSize=1000").Result;
            var rawData = response.Content.ReadAsStringAsync().Result;
            dynamic jsonObj = JsonConvert.DeserializeObject(rawData);
            return jsonObj?.items?.ToObject<List<Run>>();
        }

        private void SetUpHttpClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.runkeeper.com/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.IfModifiedSince = syncSettingsRepository.GetLastUpdatedTime();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", RunkeeperToken);
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.com.runkeeper.FitnessActivityFeed+json"));
        }
    }
}