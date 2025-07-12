using basics.Models;
using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class CourseController : Controller
{
    public IActionResult Index()
    {
        var kurs = new Course();
        kurs.Id = 1;
        kurs.Title = "AspNet Core Kursu";
        kurs.Description = "Güzel bir kurs";

        return View(kurs);
    }

    public IActionResult List()
    {
        var kurslar = new List<Course>()
        {
            new Course() {Id = 1, Title = "aspnet kursu",Description = "Güzel bir kurs"},
            new Course() {Id = 2, Title = "php kursu",Description = "Güzel bir kurs"},
            new Course() {Id = 3, Title = "django kursu",Description = "Güzel bir kurs"}
        };
        return View("CourseList", kurslar);
    }
    
}