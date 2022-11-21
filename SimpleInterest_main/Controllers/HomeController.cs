namespace BasicWebApp.Controllers;

public class HomeController : Controller
{
    public IActionResult Index(string id)
    {   
        ViewBag.Guest = id ?? "User";
        return View("Index");
    }

    public IActionResult Simple(double principle, double rate, int period,[FromServices]SimpleInterest.Service.ICalculate calculate)
    {   
        ViewBag.Simple = calculate.SimpleIntr(principle, rate, period);
        return View("Result");
    }

}
