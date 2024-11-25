using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegramNotifierApi.DTO
{
    public class GenericResponse
    {
        public int Code { get; internal set; }
        public string? Message { get; internal set; }
    }
}