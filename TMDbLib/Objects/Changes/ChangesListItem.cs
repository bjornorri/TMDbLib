﻿using Newtonsoft.Json;

namespace TMDbLib.Objects.Changes
{
    public class ChangesListItem
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("adult")]
        public bool? Adult { get; set; }
    }
}