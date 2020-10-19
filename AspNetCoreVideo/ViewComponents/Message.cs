using AspNetCoreVideo.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreVideo.ViewComponents
{
    public class Message : ViewComponent
    {
        private readonly IMessageService _messageService;

        public Message(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public IViewComponentResult Invoke()
        {
            var model = _messageService.GetAppSettingsData;
            return View("Default", model);
        }
    }
}
