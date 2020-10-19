using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public interface IMessageService
    {
        string ApplicationName { get; }
        string GetAppSettingsData { get; }

        string GetEnvironmentName { get; }
    }
}
