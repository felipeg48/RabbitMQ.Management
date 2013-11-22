using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{
	public class RabbitMQModel
	{

		[JsonProperty("management_version")]
		public string ManagementVersion { get; set; }

		[JsonProperty("statistics_level")]
		public string StatisticsLevel { get; set; }

		[JsonProperty("exchange_types")]
		public ExchangeType[] ExchangeTypes { get; set; }

		[JsonProperty("rabbitmq_version")]
		public string RabbitmqVersion { get; set; }

		[JsonProperty("erlang_version")]
		public string ErlangVersion { get; set; }

		[JsonProperty("erlang_full_version")]
		public string ErlangFullVersion { get; set; }

		[JsonProperty("message_stats")]
		public MessageStats MessageStats { get; set; }

		[JsonProperty("queue_totals")]
		public QueueTotals QueueTotals { get; set; }

		[JsonProperty("object_totals")]
		public ObjectTotals ObjectTotals { get; set; }

		[JsonProperty("node")]
		public string Node { get; set; }

		[JsonProperty("statistics_db_node")]
		public string StatisticsDbNode { get; set; }

		[JsonProperty("listeners")]
		public Listener[] Listeners { get; set; }

		[JsonProperty("contexts")]
		public Context[] Contexts { get; set; }
	}

    public class ExchangeType
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }

    public class PublishDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class AckDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class DeliverGetDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class RedeliverDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class DeliverDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class GetDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class GetNoAckDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MessageStats
    {

        [JsonProperty("publish")]
        public int Publish { get; set; }

        [JsonProperty("publish_details")]
        public PublishDetails PublishDetails { get; set; }

        [JsonProperty("ack")]
        public int Ack { get; set; }

        [JsonProperty("ack_details")]
        public AckDetails AckDetails { get; set; }

        [JsonProperty("deliver_get")]
        public int DeliverGet { get; set; }

        [JsonProperty("deliver_get_details")]
        public DeliverGetDetails DeliverGetDetails { get; set; }

        [JsonProperty("redeliver")]
        public int Redeliver { get; set; }

        [JsonProperty("redeliver_details")]
        public RedeliverDetails RedeliverDetails { get; set; }

        [JsonProperty("deliver")]
        public int Deliver { get; set; }

        [JsonProperty("deliver_details")]
        public DeliverDetails DeliverDetails { get; set; }

        [JsonProperty("get")]
        public int Get { get; set; }

        [JsonProperty("get_details")]
        public GetDetails GetDetails { get; set; }

        [JsonProperty("get_no_ack")]
        public int GetNoAck { get; set; }

        [JsonProperty("get_no_ack_details")]
        public GetNoAckDetails GetNoAckDetails { get; set; }
    }

    public class MessagesDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MessagesReadyDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MessagesUnacknowledgedDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class QueueTotals
    {

        [JsonProperty("messages")]
        public int Messages { get; set; }

        [JsonProperty("messages_details")]
        public MessagesDetails MessagesDetails { get; set; }

        [JsonProperty("messages_ready")]
        public int MessagesReady { get; set; }

        [JsonProperty("messages_ready_details")]
        public MessagesReadyDetails MessagesReadyDetails { get; set; }

        [JsonProperty("messages_unacknowledged")]
        public int MessagesUnacknowledged { get; set; }

        [JsonProperty("messages_unacknowledged_details")]
        public MessagesUnacknowledgedDetails MessagesUnacknowledgedDetails { get; set; }
    }

    public class ObjectTotals
    {

        [JsonProperty("consumers")]
        public int Consumers { get; set; }

        [JsonProperty("queues")]
        public int Queues { get; set; }

        [JsonProperty("exchanges")]
        public int Exchanges { get; set; }

        [JsonProperty("connections")]
        public int Connections { get; set; }

        [JsonProperty("channels")]
        public int Channels { get; set; }
    }

    public class Listener
    {

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("protocol")]
        public string Protocol { get; set; }

        [JsonProperty("ip_address")]
        public string IpAddress { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }
    }

    public class Context
    {

        [JsonProperty("node")]
        public string Node { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("ignore_in_use")]
        public bool? IgnoreInUse { get; set; }
    }

    
}
