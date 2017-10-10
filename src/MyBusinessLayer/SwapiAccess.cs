using MyBusinessLayer.Models;
using Newtonsoft.Json;
using System;
using System.Net.Http;

namespace MyBusinessLayer
{
    /// <summary>
    /// A quick and dirty business layer.
    /// </summary>
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

            var index = random.Next(0, data.Starships.Length - 1);

            return data.Starships[index];
        }

        private void FetchData()
        {
            var http = new HttpClient();
            var response = http.GetAsync("https://swapi.co/api/starships/").Result;
            var result = response.Content.ReadAsStringAsync().Result;
            data = JsonConvert.DeserializeObject<Results>(result);
        }
    }
}