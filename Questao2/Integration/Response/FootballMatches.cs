using Newtonsoft.Json;

namespace Questao2.Integration.Response
{
    public class FootballMatches
    {
        [JsonProperty("competition")]
        public string? Competition { get; set; }

        [JsonProperty("year")]
        public int Year { get; set; }

        [JsonProperty("round")]
        public string? Round { get; set; }

        [JsonProperty("team1")]
        public string? Team1 { get; set; }

        [JsonProperty("team2")]
        public string? Team2 { get; set; }

        [JsonProperty("team1goals")]
        public string? Team1goals { get; set; }

        [JsonProperty("team2goals")]
        public string? Team2goals { get; set; }
    }
}
