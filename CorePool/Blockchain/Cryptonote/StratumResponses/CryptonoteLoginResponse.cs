using Newtonsoft.Json;

namespace CorePool.Blockchain.Cryptonote.StratumResponses
{
    public class CryptonoteJobParams
    {
        [JsonProperty("job_id")]
        public string JobId { get; set; }

        public string Blob { get; set; }
        public string Target { get; set; }

        /// <summary>
        /// Introduced for CNv4 (aka CryptonightR)
        /// </summary>
        public ulong Height { get; set; }
    }

    public class CryptonoteLoginResponse : CryptonoteResponseBase
    {
        public string Id { get; set; }
        public CryptonoteJobParams Job { get; set; }
    }
}
