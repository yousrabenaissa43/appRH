using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using appRH.Models;

namespace appRH.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
    [HttpGet]
    public ViewResult Employees() //public IActionResult Employees()
    {
        return View();
    }
    [HttpPost]
   public ViewResult Employees(Employee employee) //public IActionResult Employees()
   {
        if (ModelState.IsValid)
        {
            Repository.AddEmployee(employee);
            return View("confirmPage", employee);
        }
        else
            return View();
    }
    public ViewResult AllEmployees()
    {
        return View(Repository.GetEmployees().Where(emp => emp.isActive == true));
    }

}
