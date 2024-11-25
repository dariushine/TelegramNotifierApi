using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using EasyNetQ;
using EasyNetQ.Topology;
using TelegramNotifierApi.DTO;

namespace TelegramNotifierApi.Services
{
    public class NotificationService : INotificationService
    {
        private readonly ILogger<NotificationService> _logger;
        private readonly IBus _bus;

        public NotificationService(ILogger<NotificationService> logger, IBus bus)
        {
            _logger = logger;
            _bus = bus;
        }

        public async Task<GenericResponse> SendNotification(Notification notification)
        {
            var exchange = await _bus.Advanced.ExchangeDeclareAsync("notifications", ExchangeType.Direct);
            var routingKey = "key";
            var message = new Message<Notification>(notification);

            await _bus.Advanced.PublishAsync(exchange, routingKey, true, message);
            return new GenericResponse{ Code = 1000, Message = "Task executed successfully"};
        }
    }
}