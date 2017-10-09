namespace MyBusinessLayer.Models
{
    public class Starship
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public string Manufacturer { get; set; }

        public double Length { get; set; }

        [Newtonsoft.Json.JsonProperty(PropertyName = "cost_in_credits")]
        public string Cost { get; set; }
    }
}