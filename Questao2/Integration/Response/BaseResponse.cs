﻿using Newtonsoft.Json;

namespace Questao2.Integration.Response
{
    public class BaseResponse<T>
    {
        [JsonProperty("page")]
        public int Page { get; set; }
        [JsonProperty("per_page")]
        public int PerPage { get; set; }
        [JsonProperty("total")]
        public int Total { get; set; }
        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }
        [JsonProperty("data")]
        public List<T>? Data { get; set; }

    }
}
