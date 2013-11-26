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



