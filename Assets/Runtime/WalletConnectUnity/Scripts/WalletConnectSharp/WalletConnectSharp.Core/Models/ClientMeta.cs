using System;
using Newtonsoft.Json;

namespace WalletConnectSharp.Core.Models
{
    [Serializable]
    public class ClientMeta
    {
        [JsonProperty("description")]
        public string Description = "This is a test of the Nethereum.WalletConnect feature";

        [JsonProperty("url")]
        public string URL = "https://app.warriders.com";

        [JsonProperty("icons")]
        public string[] Icons = new[] {"https://app.warriders.com/favicon.ico"};

        [JsonProperty("name")]
        public string Name = "WalletConnect Test";
    }
}
