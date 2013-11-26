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
			//WebClient wc = new WebClient();
			//var json = wc.DownloadString("http://guest:guest@localhost:15672/api/overview");
			//dynamic rmq = JsonConvert.DeserializeObject<dynamic>(json);

			HttpWebRequest webRequest = (HttpWebRequest)WebRequest.Create("http://localhost:15672/api/overview");
			webRequest.Method = "GET";
			webRequest.Accept = "application/json";
			webRequest.Credentials = new NetworkCredential ("guest", "guest");

			var webResponse = (HttpWebResponse)webRequest.GetResponse();

			RabbitMQModel rmq = JsonConvert.DeserializeObject<RabbitMQModel>(new StreamReader(webResponse.GetResponseStream()).ReadToEnd());
			return rmq;
		}

	}
}

