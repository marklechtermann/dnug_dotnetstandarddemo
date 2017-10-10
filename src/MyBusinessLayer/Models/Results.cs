namespace MyBusinessLayer.Models
{
    public class Results
    {
        public int Count { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "results")]
        public Starship[] Starships { get; set; }
    }
}