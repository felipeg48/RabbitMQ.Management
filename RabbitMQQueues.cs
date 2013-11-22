using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{
	public class RabbitMQQueue
	{

		[JsonProperty("memory")]
		public int Memory { get; set; }

		[JsonProperty("idle_since")]
		public string IdleSince { get; set; }

		[JsonProperty("policy")]
		public string Policy { get; set; }

		[JsonProperty("exclusive_consumer_tag")]
		public string ExclusiveConsumerTag { get; set; }

		[JsonProperty("consumers")]
		public int Consumers { get; set; }

		[JsonProperty("backing_queue_status")]
		public BackingQueueStatus BackingQueueStatus { get; set; }

		[JsonProperty("status")]
		public string Status { get; set; }

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

		[JsonProperty("node")]
		public string Node { get; set; }

		[JsonProperty("message_stats")]
		public MessageStats MessageStats { get; set; }

		[JsonProperty("messages")]
		public int? Messages { get; set; }

		[JsonProperty("messages_details")]
		public MessagesDetails MessagesDetails { get; set; }

		[JsonProperty("messages_ready")]
		public int? MessagesReady { get; set; }

		[JsonProperty("messages_ready_details")]
		public MessagesReadyDetails MessagesReadyDetails { get; set; }

		[JsonProperty("messages_unacknowledged")]
		public int? MessagesUnacknowledged { get; set; }

		[JsonProperty("messages_unacknowledged_details")]
		public MessagesUnacknowledgedDetails MessagesUnacknowledgedDetails { get; set; }
	}

    public class BackingQueueStatus
    {

        [JsonProperty("q1")]
        public int Q1 { get; set; }

        [JsonProperty("q2")]
        public int Q2 { get; set; }

        [JsonProperty("delta")]
        public object[] Delta { get; set; }

        [JsonProperty("q3")]
        public int Q3 { get; set; }

        [JsonProperty("q4")]
        public int Q4 { get; set; }

        [JsonProperty("len")]
        public int Len { get; set; }

        [JsonProperty("pending_acks")]
        public int PendingAcks { get; set; }

        [JsonProperty("target_ram_count")]
        public string TargetRamCount { get; set; }

        [JsonProperty("ram_msg_count")]
        public int RamMsgCount { get; set; }

        [JsonProperty("ram_ack_count")]
        public int RamAckCount { get; set; }

        [JsonProperty("next_seq_id")]
        public int NextSeqId { get; set; }

        [JsonProperty("persistent_count")]
        public int PersistentCount { get; set; }

        [JsonProperty("avg_ingress_rate")]
        public double AvgIngressRate { get; set; }

        [JsonProperty("avg_egress_rate")]
        public double AvgEgressRate { get; set; }

        [JsonProperty("avg_ack_ingress_rate")]
        public double AvgAckIngressRate { get; set; }

        [JsonProperty("avg_ack_egress_rate")]
        public int AvgAckEgressRate { get; set; }
    }

    public class Arguments
    {
    }

    public class AckDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class DeliverDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class DeliverGetDetails
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

    public class PublishDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class RedeliverDetails
    {

        [JsonProperty("rate")]
        public int Rate { get; set; }
    }

    public class MessageStats
    {

        [JsonProperty("ack")]
        public int Ack { get; set; }

        [JsonProperty("ack_details")]
        public AckDetails AckDetails { get; set; }

        [JsonProperty("deliver")]
        public int Deliver { get; set; }

        [JsonProperty("deliver_details")]
        public DeliverDetails DeliverDetails { get; set; }

        [JsonProperty("deliver_get")]
        public int DeliverGet { get; set; }

        [JsonProperty("deliver_get_details")]
        public DeliverGetDetails DeliverGetDetails { get; set; }

        [JsonProperty("get")]
        public int Get { get; set; }

        [JsonProperty("get_details")]
        public GetDetails GetDetails { get; set; }

        [JsonProperty("get_no_ack")]
        public int GetNoAck { get; set; }

        [JsonProperty("get_no_ack_details")]
        public GetNoAckDetails GetNoAckDetails { get; set; }

        [JsonProperty("publish")]
        public int Publish { get; set; }

        [JsonProperty("publish_details")]
        public PublishDetails PublishDetails { get; set; }

        [JsonProperty("redeliver")]
        public int Redeliver { get; set; }

        [JsonProperty("redeliver_details")]
        public RedeliverDetails RedeliverDetails { get; set; }
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

    

}
