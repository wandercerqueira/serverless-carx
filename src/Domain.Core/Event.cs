﻿namespace Domain.Core
{
    using System;
    using Newtonsoft.Json;

    public class Event<T> where T : class
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "subject")]
        public string Subject { get; set; }

        [JsonProperty(PropertyName = "eventType")]
        public string EventType { get; set; }

        [JsonProperty(PropertyName = "data")]
        public T Data { get; set; }

        [JsonProperty(PropertyName = "eventTime")]
        public DateTime EventTime { get; set; }
    }
}
