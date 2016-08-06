using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mm_aspnet_core_deployment.Services
{
    public interface ISmsSender
    {
        Task SendSmsAsync(string number, string message);
    }
}
