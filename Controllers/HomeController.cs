using JD.com.Context;
using JD.com.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace JD.com.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly DatabaseContext _context;

        public HomeController(ILogger<HomeController> logger,DatabaseContext context)
        {
            _logger = logger;
            this._context = context;
        }

        public IActionResult Index()
        {
          
            return View();
        }

        public async Task<IActionResult> Privacy()
        {
            var data =  _context.CourseGroup.ToList();
            /*var res = (from item in data group item by item.CourseGroupName);*/
            return View(data);
        }
        public JsonResult getCourse(int Id)
        {
            var res = _context.Courses
            .Where(item => item.CourseGroupId == Id)
                  .Select(item => new
                  {
                      item.CourseId,
                      item.CourseName,
                      Colleges = item.Colleges.Select(college => new
                      {
                          college.CollegeId,
                          college.CollegeName,
                          stateName=college.state.StateName
                      })
                  }).ToList();
            return Json(res);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
