using Alb.BlazorApp.Shared.Contracts.Comunication;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

namespace Alb.BlazorApp.Server.Infraestructure
{
    public class RabbotMqService : IComunication
    {
        private readonly string _hostname = "localhost";
        private readonly string _queueName = "blazorQueue";
        private readonly string _replyQueueName = "blazorReplyQueue";
        private readonly IConnection _connection;
        private readonly IModel _channel;


        public RabbotMqService()
        {
            var factory = new ConnectionFactory() { HostName = _hostname };
            _connection = factory.CreateConnection();
            _channel = _connection.CreateModel();
            _channel.QueueDeclare(queue: _queueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
            _channel.QueueDeclare(queue: _replyQueueName, durable: false, exclusive: false, autoDelete: false, arguments: null);
        }



        public async Task<string> SendDtoToMicroservice(string msg)
        {
            var body = Encoding.UTF8.GetBytes(msg);

            /* {... send } */

            var response = "recibir respuesta";

            return response;
        }
    }
}
