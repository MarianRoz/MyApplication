using Microsoft.AspNetCore.Mvc;
using MyApplication2.Services;
using System.Diagnostics;

namespace MyApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnnouncementService _service;   
        public HomeController(IAnnouncementService service)
        {
                _service = service;
        }
        [HttpGet]
        [Route("AddAnnouncement")]
        public void AddAnnouncement(string announcement) { }
        [HttpGet]
        [Route("EditAnnouncement")]
        public void EditAnnouncement(string announcement) { }
        [HttpGet]
        [Route("DeleteAnnouncement")]
        public void DeleteAnnouncement(string announcement) { }
        [HttpGet]
        [Route("SeeAnnouncement")]
        public void SeeAnnouncement(string announcement) { }
        [HttpGet]
        [Route("ShowAnnouncement")]
        public void ShowAnnouncement(string announcement) { }
    }
}
