using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.Services
{
    public class ConfigurationMessageService : IMessageService
    {
        private readonly IHostEnvironment _env;
        private readonly IConfiguration _config;

        public ConfigurationMessageService(IHostEnvironment env,
            IConfiguration config)
        {
            _env = env;
            _config = config;
        }

        public string ApplicationName => _env.ApplicationName;

        public string GetAppSettingsData => _config["Message"];

        public string GetEnvironmentName => _env.EnvironmentName;
    }
}
