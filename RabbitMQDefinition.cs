 using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{

    public class User
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("password_hash")]
        public string PasswordHash { get; set; }

        [JsonProperty("tags")]
        public string Tags { get; set; }
    }

    public class Vhost
    {

        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Permission
    {

        [JsonProperty("user")]
        public string User { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("configure")]
        public string Configure { get; set; }

        [JsonProperty("write")]
        public string Write { get; set; }

        [JsonProperty("read")]
        public string Read { get; set; }
    }

    public class Arguments
    {
    }

    public class Queue
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("durable")]
        public bool Durable { get; set; }

        [JsonProperty("auto_delete")]
        public bool AutoDelete { get; set; }

        [JsonProperty("arguments")]
        public Arguments Arguments { get; set; }
    }

    public class Arguments2
    {
    }

    public class Exchanx
    {

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
        public Arguments2 Arguments { get; set; }
    }

    public class Arguments3
    {
    }

    public class Binding
    {

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("vhost")]
        public string Vhost { get; set; }

        [JsonProperty("destination")]
        public string Destination { get; set; }

        [JsonProperty("destination_type")]
        public string DestinationType { get; set; }

        [JsonProperty("routing_key")]
        public string RoutingKey { get; set; }

        [JsonProperty("arguments")]
        public Arguments3 Arguments { get; set; }
    }

    public class RabbitMQDefinition
    {

        [JsonProperty("rabbit_version")]
        public string RabbitVersion { get; set; }

        [JsonProperty("users")]
        public User[] Users { get; set; }

        [JsonProperty("vhosts")]
        public Vhost[] Vhosts { get; set; }

        [JsonProperty("permissions")]
        public Permission[] Permissions { get; set; }

        [JsonProperty("parameters")]
        public object[] Parameters { get; set; }

        [JsonProperty("policies")]
        public object[] Policies { get; set; }

        [JsonProperty("queues")]
        public Queue[] Queues { get; set; }

        [JsonProperty("exchanges")]
        public Exchanx[] Exchanges { get; set; }

        [JsonProperty("bindings")]
        public Binding[] Bindings { get; set; }
    }

}
