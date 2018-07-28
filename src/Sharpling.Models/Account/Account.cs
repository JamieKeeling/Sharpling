using Newtonsoft.Json;

namespace Sharpling.Models
{
    public class Account
    {
        [JsonProperty]
        public string Id { get; private set; }
        [JsonProperty]
        public string Name { get; private set; }
        [JsonProperty]
        public string SortCode { get; private set; }
        [JsonProperty]
        public string AccountNumber { get; private set; }
        [JsonProperty]
        public string IBAN { get; private set; }
        [JsonProperty]
        public string BIC { get; private set; }
        [JsonProperty]
        public string CreatedAt { get; private set; }
    }
}
