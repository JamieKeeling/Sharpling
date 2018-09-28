using Newtonsoft.Json;

namespace Sharpling.Models.Account
{
    public class AccountBalance
    {
        [JsonProperty]
        public decimal ClearedBalance { get; set; }
        [JsonProperty]
        public decimal EffectiveBalance { get; set; }
        [JsonProperty]
        public decimal PendingTransactions { get; set; }
        [JsonProperty]
        public decimal AvailableToSpend { get; set; }
        [JsonProperty]
        public decimal AcceptedOverdraft { get; set; }
        [JsonProperty]
        public string Currency { get; set; }
        [JsonProperty]
        public decimal Amount { get; set; }
    }
}
