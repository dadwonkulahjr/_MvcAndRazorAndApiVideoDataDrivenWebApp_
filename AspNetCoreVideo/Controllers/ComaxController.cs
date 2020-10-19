using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCoreVideo.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    public class ComaxController : Controller
    {
        private readonly IComaxEmployeeService _comaxEmployeeService;
        private readonly IMessageService _messageService;

        public ComaxController(IComaxEmployeeService comaxEmployeeService,
            IMessageService messageService)
        {
            _comaxEmployeeService = comaxEmployeeService;
            _messageService = messageService;
        }
        [Route("/Comax")]
        [Route("/Comax/Index")]
        public ContentResult Index()
        {
            return Content("My name is Dad S Wonkulah Jr");
        }
        public ObjectResult ListOfComaxEmployees()
        {
            return new ObjectResult(_comaxEmployeeService.GetAllComaxStaffs());
        }

        public ContentResult GetApplicationName()
        {
            return Content("Application Name: " + _messageService.ApplicationName);
        }

        public ContentResult GetEnvironmentName()
        {
            return Content("Environment Name: " + _messageService.GetEnvironmentName);
        }

        public ContentResult GetConfigurationSettings()
        {
            return Content("Appsettings.json: " + _messageService.GetAppSettingsData);
        }
    }
}
