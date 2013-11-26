using NUnit.Framework;
using System;
using RabbitMQ.Management;
using System.Dynamic;

namespace RabbitMQ.Management.Test
{
	[TestFixture ()]
	public class MainTest
	{
		[Test ()]
		public void TestCase ()
		{
			RabbitMQModel result = RabbitMQManager.GetOverview ();
			Assert. IsNotNull (result);
		}
	}
}

