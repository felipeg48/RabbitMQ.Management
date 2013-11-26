using NUnit.Framework;
using System;
using RabbitMQ.Management;
using System.Dynamic;

namespace RabbitMQ.Management.Test
{
	[TestFixture]
	public class MainTest
	{
		[Test]
		public void OverviewTest ()
		{
			RabbitMQModel result = RabbitMQManager.GetOverview ();
			Assert. IsNotNull (result.MessageStats);
			Assert. IsNotNull (result.QueueTotals);
			Assert. IsNotNull (result);
		}

		[Test]
		[Ignore]
		public void DynamicTest ()
		{

			//Step Get the Admin
			dynamic s = new RabbitMQAdmin ();

			dynamic admin = s.Connect.To("localhost").WithCredentials("","");
			//dynamic admin = s.Connect.To("localhost").WithCredentials("","").UseSSL(true);


			//admin.Create
			//	.Alarm
			//	.If
			//	.Queue.Messages.Ready.Is(10)
			//	.Then
			//	.Send.Email(...)

		}
	}
}

