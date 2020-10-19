using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetCoreVideo.Entities;
using AspNetCoreVideo.Models;
using AspNetCoreVideo.Services;
using AspNetCoreVideo.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;

namespace AspNetCoreVideo.Controllers
{
    [Route("[controller]/[action]/{id?}")]
    [Authorize]
    public class HomeController : Controller
    {
        private readonly IPersonService _personService;
        private readonly IVideoDataRepository _videoDataRepository;

        public HomeController(IPersonService personService,
            IVideoDataRepository videoDataRepository)
        {
            _personService = personService;
            _videoDataRepository = videoDataRepository;
        }
        #region 
        //Route Template
        [Route(template: "/Home")]
        [Route(template: "/Home/Index")]
        #endregion
        [AllowAnonymous]
        public ViewResult Index()
        {
            var model = _videoDataRepository.GetAll()
                                    .Select(v => new VideoViewModel()
                                    {
                                        Id = v.Id,
                                        Title = v.Title,
                                        Genre = v.Genre.ToString()
                                    });
            //from video in _videoDataRepository.GetAll()
            //        select new VideoViewModel
            //        {
            //            Id = video.Id,
            //            Title = video.Title,
            //            Genre = Enum.GetName(typeof(Genres), video.GenreId)
            //        };
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _videoDataRepository.GetVideoById(id);
            if (model != null)
            {
                return View(new VideoViewModel()
                {
                    Id = model.Id,
                    Title = model.Title,
                    Genre = model.Genre.ToString()
                });
            }
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(VideoEditViewModel model)
        {
            if (ModelState.IsValid)
            {
                var video = new Video()
                {
                    Title = model.Title,
                    Genre = model.Genre
                };

                _videoDataRepository.AddNewVideo(video);
                return RedirectToAction("Details", new { id = video.Id });
            }

            return View();
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var model = _videoDataRepository.GetVideoById(id);
            if (model != null)
            {
                return View(model);
            }

            return RedirectToAction("Index");
        }
        [HttpPost]
        public IActionResult Edit(int id, VideoEditViewModel videoEditViewModel)
        {
            var video = _videoDataRepository.GetVideoById(id);
            if (video != null)
            {
                if (ModelState.IsValid)
                {
                    video.Title = videoEditViewModel.Title;
                    video.Genre = videoEditViewModel.Genre;
                    _videoDataRepository.Commit();
                    return RedirectToAction("Details", new { id = video.Id});
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return RedirectToAction("Index");
            }

        }
        public ContentResult Welcome()
        {
            return Content("Welcome Home tuseTheProgrammer!");
        }

        public ContentResult DisplayPersonDetails()
        {
            Person person = _personService.GetEmployeeById(101);
            if (person != null)
            {
                return Content($"Name: {person.FirstName + ", " + person.LastName} - Salary: {person.Salary.Value.ToString("c")}");
            }
            return Content($"No employee found!");
        }
    }
}
