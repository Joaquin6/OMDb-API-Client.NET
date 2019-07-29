using Newtonsoft.Json;

namespace OMDbApiNetClient.Model
{
    public class Rating
    {
        [JsonProperty("Source")]
        public string Source { get; set; }

        [JsonProperty("Value")]
        public string Value { get; set; }
    }
}
