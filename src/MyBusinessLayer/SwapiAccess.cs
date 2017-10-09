using MyBusinessLayer.Models;
using System;
using System.Net.Http;

namespace MyBusinessLayer
{
    public class SwapiAccess
    {
        private static Results data;

        private static Random random = new Random();

        public Starship GetRandomStarship()
        {
            if (data == null)
            {
                this.FetchData();
            }

            var index = random.Next(0, data.results.Length - 1);

            return data.results[index];
        }

        private void FetchData()
        {
            var http = new HttpClient();
            var response = http.GetAsync("https://swapi.co/api/starships/").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            data = Newtonsoft.Json.JsonConvert.DeserializeObject<Results>(result);
        }
    }
}