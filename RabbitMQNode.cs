using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{
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

    public class ExchangeType
    {

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
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

    public class Context
    {

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("port")]
        public int Port { get; set; }

        [JsonProperty("ignore_in_use")]
        public bool IgnoreInUse { get; set; }
    }

   

}
