using MeetingApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace MeetingApp.Controllers
{
    public class HomeController: Controller
    {
        public IActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewData["Greeting"] = hour > 12 ? "Have a nice day" : "Good morning";
            int userCount = Repository.Users.Where(info => info.WillAttend == true).Count();

            var meetingInfo = new MeetingInfo()
            {
                Id = 1,
                Location = "Istanbul, Turkey",
                Date = new DateTime(2024, 01, 20, 20, 0, 0),
                NumberOfPeople = userCount
            };

            return View(meetingInfo);
        }
    }
}