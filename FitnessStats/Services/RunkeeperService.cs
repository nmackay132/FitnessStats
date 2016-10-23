using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using FitnessStats.Models;
using Newtonsoft.Json;

namespace FitnessStats.Services
{
    public class RunkeeperService
    {
        public List<Run> GetRuns()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.runkeeper.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                string token = "1c349751b3de41d1ada3efc27becff7d";
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.com.runkeeper.FitnessActivityFeed+json"));
                HttpResponseMessage response = client.GetAsync("fitnessActivities?pageSize=1000").Result;
                string rawData = response.Content.ReadAsStringAsync().Result;
                dynamic jsonObj = JsonConvert.DeserializeObject(rawData);
                List<Run> myRuns = jsonObj.items.ToObject<List<Run>>();
                return myRuns;
            }
        }
    }
}