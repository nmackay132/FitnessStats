using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using FitnessStats.Models;

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
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage response = client.GetAsync(String.Format("fitnessActivities?pageSize=1000")).Result;
                RunsObject myRuns = response.Content.ReadAsAsync<RunsObject>().Result;

                return myRuns.Runs; ;
            }
        }
    }
}