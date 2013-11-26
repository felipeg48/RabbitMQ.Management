using System;
using System.Dynamic;
using System.Net;
using System.Text;
using System.IO;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace RabbitMQ.Management
{
	public class RabbitMQManager //: DynamicObject
	{
		public static RabbitMQModel GetOverview()
		{
			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:15672/api/overview");
			webRequest.Method = "GET";
			webRequest.Accept = "application/json";
			webRequest.Credentials = new NetworkCredential ("guest", "guest");

			var webResponse = (HttpWebResponse)webRequest.GetResponse();

			RabbitMQModel rmq = JsonConvert.DeserializeObject<RabbitMQModel>(new StreamReader(webResponse.GetResponseStream()).ReadToEnd());
			return rmq;
		}

	}

	public class RabbitMQAdmin : DynamicObject
	{

	}
}

