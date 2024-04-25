using Microsoft.AspNetCore.Mvc;
using Sana_bootcamp_task_1.Models;

namespace Sana_bootcamp_task_1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index() => View(new User());
    
    [HttpPost]
    public IActionResult Greeting(User user) => 
        !ModelState.IsValid ? View("./Index", user) : View(ViewData["GreetingMessage"] = $"Hello, {user.FullName}!");

}