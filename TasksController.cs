using Microsoft.AspNetCore.Mvc;
using RabbitMQ.Client;
using System.Text;

[ApiController]
[Route("api/tasks")]
public class TasksController : ControllerBase
{
    [HttpPost]
    public IActionResult CreateTask([FromBody] string taskName)
    {
        var factory = new ConnectionFactory { HostName = "rabbitmq" };
        using var connection = factory.CreateConnection();
        using var channel = connection.CreateModel();

        channel.QueueDeclare("tasks", false, false, false);
        var body = Encoding.UTF8.GetBytes(taskName);
        channel.BasicPublish("", "tasks", null, body);

        return Ok("Task submitted");
    }
}