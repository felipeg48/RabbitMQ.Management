RabbitMQ.Management
===================

A C# RabbitMQ Management library. It's a wrapper of the REST API that RabbitMQ server provides.

##Features

- Get Overview of the RabbitMQ Server
- Health of the RabbitMQ Server
- Get the Messages Ready per Queue
- Get the Number of Messages Acknowledge
- Set Alarms based on any stat such as memory, number of messages, etc


## Examples

```csharp
	var manager = new RabbitMQManager.GetOverview()
	result.QueueTotals; 			
```

## TODO

- Work with the ***dynamic*** keyword to get a clean way to access properties of the manager object.
- Add a Fluent API for setting the alarms and connect to the server.

Examples:

```csharp
	var manager = RabbitMQAdmin.Connect.To("localhost").WithCredentials("","").UseSSL(true);`
	manager.Create
				.Alarm
				.If
				.Queue.Messages.Ready.Is(10)
				.Then
				.Send.Email("admin@mycompany.com");
```




