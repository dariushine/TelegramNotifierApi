using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TelegramNotifierApi.DTO;
using TelegramNotifierApi.Services;

namespace TelegramNotifierApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NotificationController : ControllerBase
    {
        private readonly ILogger<NotificationController> _logger;
        private readonly INotificationService _notificationService;

        public NotificationController(ILogger<NotificationController> logger, INotificationService notificationService)
        {
            _logger = logger;
            _notificationService = notificationService;
        }

        [HttpPost(Name = "PostNotification")]
        public async Task<IActionResult> Post([FromBody] Notification notification)
        {
            return Ok(await _notificationService.SendNotification(notification));
        }
        
    }
}