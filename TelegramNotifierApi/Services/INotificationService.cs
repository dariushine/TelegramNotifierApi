using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TelegramNotifierApi.DTO;

namespace TelegramNotifierApi.Services
{
    public interface INotificationService
    {
        public Task<GenericResponse> SendNotification(Notification notification);

        
    }
}