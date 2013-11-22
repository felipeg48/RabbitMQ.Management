using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{

    public class PublishInDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class PublishOutDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MessageStats
    {

        [JsonProperty("publish_in")]
        public int PublishIn { get; set; }

        [JsonProperty("publish_in_details")]
        public PublishInDetails PublishInDetails { get; set; }

        [JsonProperty("publish_out")]
        public int PublishOut { get; set; }

        [JsonProperty("publish_out_details")]
        public PublishOutDetails PublishOutDetails { get; set; }
    }

    public class Arguments
    {
    }

    public class RabbitMQExchange
    {

        [JsonProperty("message_stats")]
        public MessageStats MessageStats { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("durable")]
        public bool Durable { get; set; }

        [JsonProperty("auto_delete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("internal")]
        public bool Internal { get; set; }

        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }
    }

}
