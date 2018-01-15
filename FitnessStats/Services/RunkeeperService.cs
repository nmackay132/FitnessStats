using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Net.Http.Headers;
using FitnessStats.Models;
using FitnessStats.Repositories;
using Newtonsoft.Json;

namespace FitnessStats.Services
{
    public class RunkeeperService : IRunkeeperService
    {
        private HttpClient _client;
        private readonly ISyncSettingsRepository _syncSettingsRepository;

        public RunkeeperService(ISyncSettingsRepository syncSettingsRepository)
        {
            _syncSettingsRepository = syncSettingsRepository;
            SetUpHttpClient();
        }

        public List<Run> GetAllRunsIfChanges()
        {
            var response = _client.GetAsync("fitnessActivities?pageSize=1000").Result;
            var rawData = response.Content.ReadAsStringAsync().Result;
            dynamic jsonObj = JsonConvert.DeserializeObject(rawData);
            return jsonObj?.items?.ToObject<List<Run>>();
        }

        private void SetUpHttpClient()
        {
            var runkeeperUrl = ConfigurationManager.AppSettings["RunkeeperUrl"];
            var runkeeperToken = ConfigurationManager.AppSettings["RunkeeperToken"];
            _client = new HttpClient { BaseAddress = new Uri(runkeeperUrl) };
            SetIfModifiedSince();
            _client.DefaultRequestHeaders.Accept.Clear();
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", runkeeperToken);
            _client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.com.runkeeper.FitnessActivityFeed+json"));

        }

        private void SetIfModifiedSince()
        {
            var modifiedTime = _syncSettingsRepository.GetLastUpdatedTime();
            if (modifiedTime != null)
            {
                _client.DefaultRequestHeaders.IfModifiedSince = modifiedTime;
            }
        }
    }
}