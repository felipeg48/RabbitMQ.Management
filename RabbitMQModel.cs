using System;
using System.Text;
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
		private object MessageStatsJson {
			set;
			get;
		}

		public MessageStats MessageStats {
			get 
			{ 
				if (this.MessageStatsJson.GetType ().IsAssignableFrom (typeof(Newtonsoft.Json.Linq.JArray)) && ((Newtonsoft.Json.Linq.JArray)this.MessageStatsJson).Count == 0)
					return (new MessageStats ());
				else if (this.MessageStatsJson.GetType ().IsAssignableFrom (typeof(Newtonsoft.Json.Linq.JObject)))
					return ((Newtonsoft.Json.Linq.JObject)MessageStatsJson).ToObject<MessageStats> ();
				else
					return null; //TODO: ?? What type to return?? I need to add more examples.
			}
		}

		[JsonProperty("queue_totals")]
		private object QueueTotalsJson { set; get; }


		public QueueTotals QueueTotals { 
			get 
			{ 
				if (this.QueueTotalsJson.GetType ().IsAssignableFrom (typeof(Newtonsoft.Json.Linq.JArray)) && ((Newtonsoft.Json.Linq.JArray)this.QueueTotalsJson).Count == 0)
					return (new QueueTotals ());
				else if (this.QueueTotalsJson.GetType ().IsAssignableFrom (typeof(Newtonsoft.Json.Linq.JObject)))
					return ((Newtonsoft.Json.Linq.JObject)QueueTotalsJson).ToObject<QueueTotals> ();
				else
					return null; //TODO: ?? What type to return?? I need to add more examples.
			
			}
		}

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

	public class RabbitMQNode
	{

		[JsonProperty("partitions")]
		public object[] Partitions { get; set; }

		[JsonProperty("os_pid")]
		public string OsPid { get; set; }

		[JsonProperty("fd_used")]
		public string FdUsed { get; set; }

		[JsonProperty("fd_total")]
		public int FdTotal { get; set; }

		[JsonProperty("sockets_used")]
		public int SocketsUsed { get; set; }

		[JsonProperty("sockets_total")]
		public int SocketsTotal { get; set; }

		[JsonProperty("mem_used")]
		public int MemUsed { get; set; }

		[JsonProperty("mem_limit")]
		public int MemLimit { get; set; }

		[JsonProperty("mem_alarm")]
		public bool MemAlarm { get; set; }

		[JsonProperty("disk_free_limit")]
		public int DiskFreeLimit { get; set; }

		[JsonProperty("disk_free")]
		public long DiskFree { get; set; }

		[JsonProperty("disk_free_alarm")]
		public bool DiskFreeAlarm { get; set; }

		[JsonProperty("proc_used")]
		public int ProcUsed { get; set; }

		[JsonProperty("proc_total")]
		public int ProcTotal { get; set; }

		[JsonProperty("statistics_level")]
		public string StatisticsLevel { get; set; }

		[JsonProperty("uptime")]
		public int Uptime { get; set; }

		[JsonProperty("run_queue")]
		public int RunQueue { get; set; }

		[JsonProperty("processors")]
		public int Processors { get; set; }

		[JsonProperty("exchange_types")]
		public ExchangeType[] ExchangeTypes { get; set; }

		[JsonProperty("auth_mechanisms")]
		public AuthMechanism[] AuthMechanisms { get; set; }

		[JsonProperty("applications")]
		public Application[] Applications { get; set; }

		[JsonProperty("contexts")]
		public Context[] Contexts { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("type")]
		public string Type { get; set; }

		[JsonProperty("running")]
		public bool Running { get; set; }
	}



	public class AuthMechanism
	{

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("enabled")]
		public bool Enabled { get; set; }
	}

	public class Application
	{

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("version")]
		public string Version { get; set; }
	}

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

	public class RabbitMQBinding
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
		public Arguments Arguments { get; set; }

		[JsonProperty("properties_key")]
		public string PropertiesKey { get; set; }
	}


	public class Arguments
	{
	}
}
